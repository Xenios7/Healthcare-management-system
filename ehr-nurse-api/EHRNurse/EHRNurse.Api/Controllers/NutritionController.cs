using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EHRNurse.Data;
using EHRNurse.Data.Models;

namespace EHRNurse.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NutritionController : ControllerBase
    {
        private readonly AppDbContext _db;

        public NutritionController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("schedule")]
        public async Task<ActionResult<IEnumerable<NutritionListItemDto>>> GetNutritionSchedule(
            [FromQuery] DateOnly date,
            [FromQuery] string status = "all",
            [FromQuery] string? search = null)
        {
            var targetDate = DateTime.SpecifyKind(
                date.ToDateTime(TimeOnly.MinValue),
                DateTimeKind.Utc
            );
            var statusLower = (status ?? "all").Trim().ToLowerInvariant();

            IQueryable<FoodDatum> query = _db.FoodData
                .AsNoTracking()
                .Include(f => f.Patient)
                .Include(f => f.FoodType)
                .Include(f => f.EpisodeCare)
                    .ThenInclude(ec => ec.AccommodationData)
                .Include(f => f.User)
                    .ThenInclude(u => u.AccommodationRooms);

            // Filter by date (FoodDatum always applies on one specific date)
            query = query.Where(f => f.OnSetDateTime.Date == targetDate.Date);

            // Optional search by patient or meal name
            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.ToLower();
                query = query.Where(f =>
                    f.Patient.FirstName.ToLower().Contains(s) ||
                    f.Patient.LastName.ToLower().Contains(s) ||
                    (f.Description ?? "").ToLower().Contains(s) ||
                    (f.Description != null && f.Description.ToLower().Contains(s))
                );
            }

            var foodItems = await query.ToListAsync();

            var dtoQuery = foodItems.Select(f =>
            {
                int? age = CalculateAge(f.Patient.DateOfBirth, DateOnly.FromDateTime(targetDate));

                // Latest accommodation
                // 1) current accommodation (patient’s stay)
                var currentAccommodation = f.EpisodeCare.AccommodationData
                    .Where(a => a.IsActive && (a.DischargeDate == null || a.DischargeDate > targetDate))
                    .OrderByDescending(a => a.RegistrationDate)  // latest stay wins
                    .FirstOrDefault();

                // 2) bed label
                var bedNumber =
                    currentAccommodation?.Bed?.Name              // if AccommodationBed has Name
                    ?? currentAccommodation?.BedId?.ToString()
                    ?? "";

                // 3) ward label from Bed -> Room -> Ward
                var wardCode =
                    currentAccommodation?.Bed?.Room?.Ward?.Name  // if AccommodationWard has Name
                    ?? currentAccommodation?.Bed?.Room?.WardId.ToString()
                    ?? "";

                // 4) days in ward from patient admission date
                var admissionDate = f.Patient.DateOfAdmission;   // DateOnly?

                int daysInWard = 0;
                if (admissionDate.HasValue)
                {
                    var adm = admissionDate.Value.ToDateTime(TimeOnly.MinValue);
                    daysInWard = (targetDate.Date - adm.Date).Days;
                    if (daysInWard < 0) daysInWard = 0;
                }


                var derivedStatus = f.IsSubmitted ? "given" : "not_given";

                return new NutritionListItemDto
                {
                    FoodId = f.Id,
                    PatientId = f.PatientId,

                    PatientName = $"{f.Patient.FirstName} {f.Patient.LastName}",
                    PatientAge = age,

                    Ward = wardCode,
                    Bed = bedNumber,
                    DaysInWard = daysInWard,

                    MealType = (f.Description ?? ""),
                    MealName = f.Description ?? "",
                    Instructions = f.Description,

                    PortionSize = f.PortionSize,
                    PortionEatenPercentage = f.PortionEatenPercentage,

                    Status = derivedStatus,
                    HasReminder = false
                };
            });

            // Apply status filter
            dtoQuery = statusLower switch
            {
                "given" => dtoQuery.Where(x => x.Status == "given"),
                "not_given" => dtoQuery.Where(x => x.Status == "not_given"),
                _ => dtoQuery
            };

            return Ok(dtoQuery.OrderBy(x => x.PatientName).ToList());
        }

        private static int? CalculateAge(DateOnly? dob, DateOnly onDate)
        {
            if (dob == null)
                return null;

            var birth = dob.Value;
            int age = onDate.Year - birth.Year;

            if (onDate < birth.AddYears(age))
                age--;

            return age;
        }
    }
}
