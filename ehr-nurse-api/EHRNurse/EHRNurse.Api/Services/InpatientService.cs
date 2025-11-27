using EHRNurse.Api.Dto;
using EHRNurse.Api.Interfaces;
using EHRNurse.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EHRNurse.Api.Services
{
    public class InpatientService : IInpatientService
    {
        private readonly AppDbContext _db;

        public InpatientService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<InpatientListItemDto>> GetAllInpatientsAsync()
        {
            var dtoList = new List<InpatientListItemDto>
            {
                new InpatientListItemDto
                {
                    PatientId = 19,
                    FirstName = "Alexandros",
                    LastName = "Theodosiou",
                    Age = 40,
                    WardId = "ER-ROOM-5",
                    Diagnosis = "Post-Surgery",
                    HasPendingMeds = true,
                    HasPendingMeals = true
                }
            };
            return await Task.FromResult(dtoList);
        }

        public async Task<IEnumerable<MedicationListItemDto>> GetMedicationsForPatientAsync(
            int patientId, DateOnly date, string status)
        {
            return await Task.FromResult(new List<MedicationListItemDto>());
        }

        public async Task<IEnumerable<NutritionListItemDto>> GetNutritionForPatientAsync(
            int patientId, DateOnly date, string status)
        {
            var filterStatus = status.ToLower().Trim();
            var targetDate = date.ToDateTime(TimeOnly.MinValue);
            var startOfDay = targetDate.Date;
            var endOfDay = startOfDay.AddDays(1).AddTicks(-1);
            
            var query = _db.FoodData
                .Where(fd => fd.PatientId == patientId)
                .Where(fd => fd.OnSetDateTime >= startOfDay && fd.OnSetDateTime <= endOfDay)
                .AsQueryable();

            if (filterStatus == "served" || filterStatus == "completed")
            {
                query = query.Where(fd => fd.IsSubmitted == true);
            }
            else if (filterStatus == "pending" || filterStatus == "not given")
            {
                query = query.Where(fd => fd.IsSubmitted == false);
            }

            var patient = await _db.Patients.FindAsync(patientId);
            var foodRecords = await query.Include(fd => fd.FoodType).ToListAsync();
            
            if (!foodRecords.Any())
            {
                return new List<NutritionListItemDto>();
            }

            // Get accommodation by PatientId (not VisitId)
            var latestAccommodation = await _db.AccommodationData
                .Include(a => a.Bed)
                .Where(a => a.PatientId == patientId && a.IsActive)
                .OrderByDescending(a => a.CreationDate)
                .FirstOrDefaultAsync();
            
            // Get ward info from the bed
            string ward = "Unknown";
            string bed = "Unknown";
            
            if (latestAccommodation?.Bed != null)
            {
                bed = latestAccommodation.Bed.Name ?? "Unknown";
                
                // Get ward from bed's room
                var bedWithRoom = await _db.AccommodationBeds
                    .Include(b => b.Room)
                        .ThenInclude(r => r.Ward)
                    .FirstOrDefaultAsync(b => b.Id == latestAccommodation.BedId);
                
                ward = bedWithRoom?.Room?.Ward?.Name ?? "Unknown";
            }
                
            var daysInWard = CalculateDaysInWard(latestAccommodation);

            var result = foodRecords.Select(fd => new NutritionListItemDto
            {
                FoodId = fd.Id,
                PatientId = fd.PatientId,
                PatientName = patient != null ? $"{patient.FirstName} {patient.LastName}" : "Unknown",
                PatientAge = patient != null ? CalculateAge(patient.DateOfBirth) : null,
                Ward = ward,
                Bed = bed,
                DaysInWard = daysInWard,
                FoodType = fd.FoodType?.Display ?? "Unknown",
                FoodTypeCode = fd.FoodType?.Code,
                PortionEatenPercentage = fd.PortionEatenPercentage,
                PortionSize = fd.PortionSize,
                Description = fd.Description,
                OnSetDateTime = DateTime.SpecifyKind(fd.OnSetDateTime, DateTimeKind.Utc),
                Status = fd.IsSubmitted ? "Served" : "Pending",
                HasAllergyWarning = fd.Description != null && 
                                   (fd.Description.ToLower().Contains("allerg") ||
                                    fd.Description.ToLower().Contains("warning"))
            }).ToList();

            return result;
        }

        public async Task<IEnumerable<MedicationListItemDto>> GetMedicationScheduleAsync(
            DateOnly date, string status, string? search)
        {
            return await Task.FromResult(new List<MedicationListItemDto>());
        }

        public async Task<IEnumerable<NutritionListItemDto>> GetNutritionScheduleAsync(
            DateOnly date, string status, string? search)
        {
            return await Task.FromResult(new List<NutritionListItemDto>());
        }

        private int? CalculateAge(DateOnly dateOfBirth)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;
            return age;
        }

        private int CalculateDaysInWard(AccommodationDatum? accommodation)
        {
            if (accommodation?.CreationDate == null)
                return 0;
            return (DateTime.Now - accommodation.CreationDate).Days;
        }
    }
}