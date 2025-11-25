using EHRNurse.Api.Dto;
using EHRNurse.Api.Interfaces;
using EHRNurse.Data.Models;

namespace EHRNurse.Api.Services
{
    public class InpatientService : IInpatientService
    {
        // Constructor: Later you will inject your DB Context here
        // private readonly EhrNurseContext _context;
        // public InpatientService(EhrNurseContext context) => _context = context;

        // PHASE 1: Main Inpatient List (For Christos - Deadline Monday)
        public async Task<IEnumerable<InpatientListItemDto>> GetAllInpatientsAsync()
        {
            // 1. SIMULATE DATABASE FETCH
            var patientsFromDb = new List<Patient>
            {
                new Patient
                {
                    Id = 101,
                    FirstName = "John",
                    LastName = "Smith",
                    DateOfBirth = new DateOnly(1959, 5, 20), // 66 years old
                    GenderId = 1,
                    Email = "john.smith@test.com",
                    IsActive = true
                },
                new Patient
                {
                    Id = 102,
                    FirstName = "Maria",
                    LastName = "Georgiou",
                    DateOfBirth = new DateOnly(1951, 8, 15), // 74 years old
                    GenderId = 2,
                    Email = "maria.g@test.com",
                    IsActive = true
                },
                 new Patient
                {
                    Id = 103,
                    FirstName = "Test",
                    LastName = "Patient2",
                    DateOfBirth = new DateOnly(1959, 1, 1),
                    GenderId = 1,
                    Email = "test@test.com",
                    IsActive = true
                }
            };

            // 2. MAP LOGIC
            var dtoList = patientsFromDb.Select(p => new InpatientListItemDto
            {
                PatientId = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Age = CalculateAge(p.DateOfBirth), // This calls the method at the bottom
                
                // MAPPING LOGIC FOR WARD (Mocked for now)
                WardId = p.Id == 101 ? "JWARD1101" : (p.Id == 102 ? "MWARD-2210" : "TWARD-1"),

                // MAPPING LOGIC FOR DIAGNOSIS (Mocked for now)
                Diagnosis = p.Id == 101 ? "Stable" : (p.Id == 102 ? "Observation" : "Recovery"),

                // LOGIC FOR ALERTS
                HasPendingMeds = p.Id == 101, 
                HasPendingMeals = false
            }).ToList();

            return await Task.FromResult(dtoList);
        }

        // PHASE 2: Medication Per Patient (For Rafalia - Deadline Thursday)
        public async Task<IEnumerable<MedicationListItemDto>> GetMedicationsForPatientAsync(int patientId)
        {
            var mockMeds = new List<MedicationListItemDto>();

            // Mock Data Logic
            if (patientId == 101) // John Smith
            {
                mockMeds.Add(new MedicationListItemDto
                {
                    MedicationId = 501,
                    PatientId = 101,
                    ProductName = "Paracetamol",
                    Quantity = 500, // Fixed: Double
                    QuantityUnit = "mg",
                    InstructionPatient = "Take after meals",
                    Status = "Given", 
                    HasReminder = false
                });
                mockMeds.Add(new MedicationListItemDto
                {
                    MedicationId = 502,
                    PatientId = 101,
                    ProductName = "Ibuprofen",
                    Quantity = 200, // Fixed: Double
                    QuantityUnit = "mg",
                    InstructionPatient = "Every 8 hours",
                    Status = "Not Given",
                    HasReminder = true
                });
            }
            else if (patientId == 102) // Maria Georgiou
            {
                mockMeds.Add(new MedicationListItemDto
                {
                    MedicationId = 601,
                    PatientId = 102,
                    ProductName = "Amoxicillin",
                    Quantity = 1000, // Fixed: Double
                    QuantityUnit = "mg",
                    InstructionPatient = "Morning only",
                    Status = "Not Given",
                    HasReminder = false
                });
            }

            return await Task.FromResult(mockMeds);
        }

        // --- THIS WAS MISSING ---
        // Helper for DateOnly
        private int CalculateAge(DateOnly dob)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            var age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age;
        }
    }
}