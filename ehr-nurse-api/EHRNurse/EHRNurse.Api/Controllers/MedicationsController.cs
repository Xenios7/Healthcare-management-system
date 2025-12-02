using EHRNurse.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EHRNurse.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicationsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public MedicationsController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("schedule")]
        public async Task<ActionResult<IEnumerable<MedicationListItemDto>>> GetMedicationSchedule(
            [FromQuery] DateOnly date,
            [FromQuery] string status = "all",
            [FromQuery] string? search = null)
        {


            var start = DateTime.SpecifyKind(
                date.ToDateTime(TimeOnly.MinValue),
                DateTimeKind.Utc
            );
            var end = start.AddDays(1);
            var statusLower = (status ?? "all").Trim().ToLowerInvariant();

            // Base query
            IQueryable<MedicationDatum> query = _db.MedicationData
                .AsNoTracking()
                .Include(m => m.Patient)
                .Include(m => m.Product)
                .Include(m => m.Package)
                .Include(m => m.QuantityUnit)
                .Include(m => m.FrequencyOfIntakeUnit)
                .Include(m => m.DurationOfTreatmentUnit)
                .Include(m => m.RouteOfAdministration)
                .Include(m => m.Visit)
                .Include(m => m.EpisodeCare)
                    .ThenInclude(e => e.AccommodationData)
                        .ThenInclude(a => a.Bed)
                            .ThenInclude(b => b.Room)
                                .ThenInclude(r => r.Ward);


            query = query.Where(m =>
                m.OnSetDateTime < end &&
                (m.EndDateTime == null || m.EndDateTime >= start)
            );

            // Text search on patient + product
            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.ToLower();
                query = query.Where(m =>
                    m.Patient.FirstName.ToLower().Contains(s) ||
                    m.Patient.LastName.ToLower().Contains(s) ||
                    m.Product.ProductName.ToLower().Contains(s));
            }

            var meds = await query.ToListAsync();

            var dtoQuery = meds.Select(m =>
            {
                var derivedStatus = GetDemoStatus(m, start);

                int? age = CalculateAge(m.Patient.DateOfBirth, date);

                // 1) current accommodation (patient’s stay)
                var currentAccommodation = m.EpisodeCare.AccommodationData
                    .Where(a => a.IsActive && (a.DischargeDate == null || a.DischargeDate > start))
                    .OrderByDescending(a => a.RegistrationDate)  // latest stay wins
                    .FirstOrDefault();

                // 2) bed label
                var bedNumber =
                    currentAccommodation?.Bed?.Name
                    ?? currentAccommodation?.BedId?.ToString()
                    ?? "";

                var wardCode =
                    currentAccommodation?.Bed?.Room?.Ward?.Name  // if AccommodationWard has Name
                    ?? currentAccommodation?.Bed?.Room?.WardId.ToString()
                    ?? "";

                // 4) days in ward from patient admission date
                var admissionDate = m.Patient.DateOfAdmission;

                int daysInWard = 0;
                if (admissionDate.HasValue)
                {
                    var adm = admissionDate.Value.ToDateTime(TimeOnly.MinValue);
                    daysInWard = (start.Date - adm.Date).Days;
                    if (daysInWard < 0) daysInWard = 0;
                }

                return new MedicationListItemDto
                {
                    MedicationId = m.Id,
                    PatientId = m.PatientId,
                    PatientName = $"{m.Patient.FirstName} {m.Patient.LastName}",
                    PatientAge = age,

                    Ward = wardCode,
                    Bed = bedNumber,
                    DaysInWard = daysInWard,

                    ProductName = m.Product.ProductName,
                    Form = m.Package.Description,
                    Quantity = m.Quantity,
                    QuantityUnit = m.QuantityUnit.Description,
                    FrequencyAmount = m.FrequencyOfIntakeAmount,
                    FrequencyUnit = m.FrequencyOfIntakeUnit.Description,
                    DurationAmount = m.DurationOfTreatmentAmount,
                    DurationUnit = m.DurationOfTreatmentUnit.Description,
                    Route = m.RouteOfAdministration?.Route,

                    InstructionPatient = m.InstructionPatient,
                    EndDate = m.EndDateTime,

                    Status = derivedStatus,
                    HasReminder = false
                };
            });

            dtoQuery = statusLower switch
            {
                "given" => dtoQuery.Where(x => x.Status == "given"),
                "not_given" => dtoQuery.Where(x => x.Status == "not_given"),
                _ => dtoQuery
            };

            var result = dtoQuery
                .OrderBy(x => x.PatientName)
                .ToList();

            return Ok(result);
        }
        private static string GetDemoStatus(MedicationDatum m, DateTime targetDate)
        {

            if (!m.IsActive)
                return "given";

            if (m.EndDateTime.HasValue && m.EndDateTime.Value.Date < targetDate.Date)
                return "given";


            if (m.OnSetDateTime.Date <= targetDate.Date &&
                (!m.EndDateTime.HasValue || m.EndDateTime.Value.Date >= targetDate.Date))
                return "not_given";


            return "not_relevant";
        }

        private static int? CalculateAge(DateOnly? dob, DateOnly onDate)
        {
            if (dob == null)
                return null;

            var birth = dob.Value;
            var today = onDate;

            int age = today.Year - birth.Year;

            if (today < birth.AddYears(age))
                age--;

            return age;
        }

    }
}
