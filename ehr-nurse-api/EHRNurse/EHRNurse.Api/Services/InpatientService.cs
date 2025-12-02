using Microsoft.EntityFrameworkCore;
using EHRNurse.Api.Dto;
using EHRNurse.Api.Interfaces;
using EHRNurse.Data.Models;

namespace EHRNurse.Api.Services
{
    public class InpatientService : IInpatientService
    {
        private readonly AppDbContext _context;

        public InpatientService(AppDbContext context)
        {
            _context = context;
        }

        // =========================================================
        // PHASE 1: Main Inpatient List
        // =========================================================
        public async Task<IEnumerable<InpatientListItemDto>> GetAllInpatientsAsync()
        {
            var patientsQuery = _context.Patients
                .AsNoTracking()
                .Where(p => p.IsActive)
                .Include(p => p.EpisodeCares)
                    .ThenInclude(e => e.AccommodationData)
                        .ThenInclude(a => a.Bed)
                            .ThenInclude(b => b.Room)
                                .ThenInclude(r => r.Ward)
                .Include(p => p.ProblemData);

            var patients = await patientsQuery.ToListAsync();

            var dtoList = patients.Select(p =>
            {
                var activeAccommodation = p.EpisodeCares
                    .SelectMany(e => e.AccommodationData)
                    .FirstOrDefault(a => a.IsActive);

                var wardName = activeAccommodation?.Bed?.Room?.Ward?.Name 
                               ?? activeAccommodation?.Bed?.Room?.WardId.ToString() 
                               ?? "Unassigned";

                var activeDiagnosis = p.ProblemData
                    .FirstOrDefault(pd => pd.IsActive)?.Description 
                    ?? "No Diagnosis";

                return new InpatientListItemDto
                {
                    PatientId = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Age = CalculateAge(p.DateOfBirth),
                    WardId = wardName,
                    Diagnosis = activeDiagnosis,
                    HasPendingMeds = false, 
                    HasPendingMeals = false
                };
            }).ToList();

            return dtoList;
        }

        // =========================================================
        // PHASE 2: Medication Per Patient 
        // =========================================================
        public async Task<IEnumerable<MedicationListItemDto>> GetMedicationsForPatientAsync(int patientId, DateOnly date, string status)
        {
            var filterStatus = status.ToLower().Trim();
            
            var targetDate = DateTime.SpecifyKind(date.ToDateTime(TimeOnly.MinValue), DateTimeKind.Utc);

            var query = _context.MedicationData
                .AsNoTracking()
                .Where(m => m.PatientId == patientId)
                // Filter by Date
                .Where(m => m.OnSetDateTime < targetDate.AddDays(1) && 
                           (m.EndDateTime == null || m.EndDateTime >= targetDate))
                .Include(m => m.Product)
                .Include(m => m.QuantityUnit)
                .Include(m => m.FrequencyOfIntakeUnit)
                .Include(m => m.Patient)
                    .ThenInclude(p => p.EpisodeCares)
                        .ThenInclude(e => e.AccommodationData)
                            .ThenInclude(a => a.Bed)
                                .ThenInclude(b => b.Room)
                                    .ThenInclude(r => r.Ward);

            var dbMeds = await query.ToListAsync();

            var dtoList = dbMeds.Select(m =>
            {
                string currentStatus = m.IsSubmitted ? "Given" : "Not Given";

                var activeAcc = m.Patient.EpisodeCares
                    .SelectMany(e => e.AccommodationData)
                    .FirstOrDefault(a => a.IsActive);
                
                string ward = activeAcc?.Bed?.Room?.Ward?.Name ?? "Unassigned";
                string bed = activeAcc?.Bed?.Name ?? "N/A";

                return new MedicationListItemDto
                {
                    MedicationId = m.Id,
                    PatientId = m.PatientId,
                    PatientName = $"{m.Patient.FirstName} {m.Patient.LastName}",
                    PatientAge = CalculateAge(m.Patient.DateOfBirth),
                    Ward = ward,
                    Bed = bed,
                    DaysInWard = 0,

                    ProductName = m.Product?.ProductName ?? "Unknown Drug",
                    Quantity = m.Quantity,
                    QuantityUnit = m.QuantityUnit?.Description ?? "units",
                    Form = "N/A", 
                    InstructionPatient = m.InstructionPatient,
                    Status = currentStatus,
                    HasReminder = false
                };
            });

            if (filterStatus == "given")
                dtoList = dtoList.Where(x => x.Status == "Given");
            else if (filterStatus.Contains("not"))
                dtoList = dtoList.Where(x => x.Status == "Not Given");

            return dtoList;
        }

        // =========================================================
        // PHASE 3: Nutrition Per Patient
        // =========================================================
        public async Task<IEnumerable<NutritionListItemDto>> GetNutritionForPatientAsync(int patientId, DateOnly date, string status)
        {
            var filterStatus = status.ToLower().Trim();
            
            var targetDate = DateTime.SpecifyKind(date.ToDateTime(TimeOnly.MinValue), DateTimeKind.Utc);

            var query = _context.FoodData
                .AsNoTracking()
                .Where(f => f.PatientId == patientId)
                .Where(f => f.OnSetDateTime.Date == targetDate.Date)
                .Include(f => f.Patient)
                    .ThenInclude(p => p.EpisodeCares)
                        .ThenInclude(e => e.AccommodationData)
                            .ThenInclude(a => a.Bed)
                                .ThenInclude(b => b.Room)
                                    .ThenInclude(r => r.Ward);

            var dbFood = await query.ToListAsync();

            var dtoList = dbFood.Select(f =>
            {
                string currentStatus = f.IsSubmitted ? "Given" : "Not Given";
                
                var activeAcc = f.Patient.EpisodeCares
                    .SelectMany(e => e.AccommodationData)
                    .FirstOrDefault(a => a.IsActive);

                return new NutritionListItemDto
                {
                    FoodId = f.Id,
                    PatientId = f.PatientId,
                    PatientName = $"{f.Patient.FirstName} {f.Patient.LastName}",
                    PatientAge = CalculateAge(f.Patient.DateOfBirth),
                    Ward = activeAcc?.Bed?.Room?.Ward?.Name ?? "Unassigned",
                    Bed = activeAcc?.Bed?.Name ?? "N/A",
                    DaysInWard = 0,

                    MealType = f.Description ?? "Meal",
                    MealName = f.Description ?? "Standard Meal",
                    Instructions = f.Description,
                    PortionSize = f.PortionSize,
                    PortionEatenPercentage = f.PortionEatenPercentage,
                    Status = currentStatus,
                    HasReminder = false
                };
            });

            if (filterStatus == "given")
                dtoList = dtoList.Where(x => x.Status == "Given");
            else if (filterStatus.Contains("not"))
                dtoList = dtoList.Where(x => x.Status == "Not Given");

            return dtoList;
        }

        private int CalculateAge(DateOnly dob)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            var age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age;
        }
    }
}