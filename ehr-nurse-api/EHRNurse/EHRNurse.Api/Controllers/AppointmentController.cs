using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EHRNurse.Data;
using EHRNurse.Data.Models;
using EHRNurse.Api.Models;

namespace EHRNurse.Api.Controllers
{
    [ApiController]
    [Route("ehr/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public AppointmentsController(AppDbContext db)
        {
            _db = db;
        }

        // GET /ehr/Appointments?filter=upcoming|completed|all
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentPatientDto>>> GetAppointments(
            [FromQuery] string filter = "upcoming",
            [FromQuery] int? patientId = null)
        {
            var now = DateTime.UtcNow;
            var f = (filter ?? "upcoming").Trim().ToLowerInvariant();

            IQueryable<AppointmentPatientDatum> query = _db.AppointmentPatientData
                .AsNoTracking()
                .Include(a => a.AppointmentStatus);

            // If patientId is passed → filter them
            if (patientId.HasValue)
            {
                query = query.Where(a => a.PatientId == patientId.Value);
            }

            // Filter logic
            if (f == "upcoming")
            {
                query = query.Where(a =>
                    a.StartDate >= now &&
                    (
                        a.AppointmentStatusId == null ||             // scheduled
                        a.AppointmentStatus!.Code == "postponed"
                    ));
            }
            else if (f == "completed")
            {
                query = query.Where(a =>
                    a.AppointmentStatus != null &&
                    a.AppointmentStatus.Code == "completed");
            }
            // else: all → no extra filtering

            // Projection to your DTO
            var list = await query
                .OrderBy(a => a.StartDate)
                .Select(a => new AppointmentPatientDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    Comments = a.Comments,
                    StartDate = a.StartDate,
                    IsRejected = a.IsRejected,
                    PatientId = a.PatientId,
                    DoctorId = a.DoctorId,

                    StatusCode = MapStatusCode(a.AppointmentStatus),
                    StatusDisplay = MapStatusDisplay(a.AppointmentStatus)
                })
                .ToListAsync();

            return Ok(list);
        }

        // PUT /ehr/Appointments/{id}/status
        [HttpPut("{id:int}/status")]
        public async Task<IActionResult> UpdateStatus(
            int id,
            [FromBody] UpdateAppointmentStatusRequest request)
        {
            var appointment = await _db.AppointmentPatientData
                .FirstOrDefaultAsync(a => a.Id == id);

            if (appointment == null)
                return NotFound("Appointment not found");

            // Convert frontend → backend code
            var backendCode = MapFrontendToBackend(request.StatusCode);
            if (backendCode == null)
                return BadRequest("Invalid status code");

            var statusRow = await _db.AppointmentStatuses
                .FirstOrDefaultAsync(s => s.Code == backendCode);

            if (statusRow == null)
                return BadRequest($"Status '{backendCode}' is not configured in DB");

            appointment.AppointmentStatusId = statusRow.Id;
            appointment.LastUpdateDate = DateTime.UtcNow;

            await _db.SaveChangesAsync();

            return Ok();
        }


        private static string MapStatusCode(AppointmentStatus? s)
        {
            if (s == null)
                return "SCHEDULED";

            return s.Code switch
            {
                "completed" => "COMPLETED",
                "postponed" => "POSTPONED",
                "cancelled" => "DNA",
                _ => "SCHEDULED"
            };
        }

        private static string MapStatusDisplay(AppointmentStatus? s)
        {
            if (s == null)
                return "Scheduled";

            return s.Code switch
            {
                "completed" => "Completed",
                "postponed" => "Postponed",
                "cancelled" => "Did not attend",
                _ => "Scheduled"
            };
        }

        private static string? MapFrontendToBackend(string code)
        {
            switch (code.ToUpperInvariant())
            {
                case "COMPLETED": return "completed";
                case "POSTPONED": return "postponed";
                case "DNA": return "cancelled";
                default: return null;
            }
        }


    }
}
