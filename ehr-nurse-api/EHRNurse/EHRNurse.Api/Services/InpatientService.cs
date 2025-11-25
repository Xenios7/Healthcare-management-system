using EHRNurse.Api.Dto;
using EHRNurse.Api.Interfaces;
using EHRNurse.Data.Models;

namespace EHRNurse.Api.Services
{
    public class InpatientService : IInpatientService
    {
        public async Task<IEnumerable<InpatientListItemDto>> GetAllInpatientsAsync()
        {
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
                Age = CalculateAge(p.DateOfBirth),
                
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

        // =========================================================
        // PHASE 2: Medication Per Patient (For Rafalia - Thursday)
        // UPDATED: Now accepts 'DateOnly date' for the UI Filter
        // =========================================================
        public async Task<IEnumerable<MedicationListItemDto>> GetMedicationsForPatientAsync(int patientId, DateOnly date)
        {
            var mockMeds = new List<MedicationListItemDto>();
            var today = DateOnly.FromDateTime(DateTime.Now);

            // --- Context for Mock Data (Extracted from GetAllInpatientsAsync) ---
            string patientName = patientId == 101 ? "John Smith" : (patientId == 102 ? "Maria Georgiou" : "Test Patient2");
            int patientAge = patientId == 101 ? 66 : 74;
            string patientWard = patientId == 101 ? "JWARD1101" : "MWARD-2210";
            // -------------------------------------------------------------------

            if (patientId == 101) // John Smith
            {
                if (date == today) 
                {
                    mockMeds.Add(new MedicationListItemDto
                    {
                        MedicationId = 501,
                        PatientId = 101,
                        
                        // --- NULL FIXES START ---
                        PatientName = patientName,
                        PatientAge = patientAge,
                        Ward = patientWard,
                        Bed = "BED-A",
                        DaysInWard = 15,
                        Form = "Tablet",
                        FrequencyAmount = 1.0,
                        FrequencyUnit = "DAY",
                        // --- NULL FIXES END ---
                        
                        ProductName = "Paracetamol",
                        Quantity = 500,
                        QuantityUnit = "mg",
                        InstructionPatient = "Take after meals",
                        Status = "Given",
                        HasReminder = false
                    });
                }
                if (date == today)
                {
                    mockMeds.Add(new MedicationListItemDto
                    {
                        MedicationId = 502,
                        PatientId = 101,
                        
                        // --- NULL FIXES START ---
                        PatientName = patientName,
                        PatientAge = patientAge,
                        Ward = patientWard,
                        Bed = "BED-A",
                        DaysInWard = 15,
                        Form = "Capsule",
                        FrequencyAmount = 2.0,
                        FrequencyUnit = "DAY",
                        // --- NULL FIXES END ---
                        
                        ProductName = "Ibuprofen",
                        Quantity = 200,
                        QuantityUnit = "mg",
                        InstructionPatient = "Every 8 hours",
                        Status = "Not Given",
                        HasReminder = true
                    });
                }
            }
            else if (patientId == 102) // Maria Georgiou
            {
                mockMeds.Add(new MedicationListItemDto
                {
                    MedicationId = 601,
                    PatientId = 102,
                    
                    // --- NULL FIXES START ---
                    PatientName = "Maria Georgiou",
                    PatientAge = 74,
                    Ward = "MWARD-2210",
                    Bed = "BED-B",
                    DaysInWard = 150,
                    Form = "Liquid",
                    FrequencyAmount = 1.0,
                    FrequencyUnit = "DAY",
                    // --- NULL FIXES END ---
                    
                    ProductName = "Amoxicillin",
                    Quantity = 1000,
                    QuantityUnit = "mg",
                    InstructionPatient = "Morning only",
                    Status = "Not Given",
                    HasReminder = false
                });
            }

            return await Task.FromResult(mockMeds);
        }

        // =========================================================
        // HELPER
        // =========================================================
        private int CalculateAge(DateOnly dob)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            var age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age;
        }
    }
}