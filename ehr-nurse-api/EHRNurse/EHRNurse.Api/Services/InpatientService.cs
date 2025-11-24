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

        public async Task<IEnumerable<InpatientListItemDto>> GetAllInpatientsAsync()
        {
            // 1. SIMULATE DATABASE FETCH
            // Since we might not have the DB seeded yet, we create "Real" patient objects here.
            // This proves your logic works with the actual Data Model.
            
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
                    IsActive = true,
                    // Simulating related data for specific UI fields:
                    // In a real DB query, you would .Include(p => p.AccommodationData)
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

            // 2. MAP LOGIC (The most important part for Xenis)
            // We transform the complex DB object into the simple JSON for Christos.
            
            var dtoList = patientsFromDb.Select(p => new InpatientListItemDto
            {
                PatientId = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Age = CalculateAge(p.DateOfBirth),
                
                // MAPPING LOGIC FOR WARD:
                // Since 'WardId' isn't on the main table, we mock it based on ID for now.
                // In Phase 2, Mourtou will write the query to get this from 'p.AccommodationData'.
                WardId = p.Id == 101 ? "JWARD1101" : (p.Id == 102 ? "MWARD-2210" : "TWARD-1"),

                // MAPPING LOGIC FOR DIAGNOSIS:
                // Similarly, diagnosis comes from 'ProblemData'. We simulate it here.
                Diagnosis = p.Id == 101 ? "Stable" : (p.Id == 102 ? "Observation" : "Recovery"),

                // LOGIC FOR ALERTS:
                // We set these manually for the demo. 
                // Later, check 'p.MedicationData' vs DateTime.Now
                HasPendingMeds = p.Id == 101, // Only John has meds pending
                HasPendingMeals = false
            }).ToList();

            return await Task.FromResult(dtoList);
        }

        // Updated Helper for DateOnly
        private int CalculateAge(DateOnly dob)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            var age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age;
        }
    }
}