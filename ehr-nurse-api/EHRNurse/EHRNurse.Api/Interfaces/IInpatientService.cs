using EHRNurse.Api.Dto;

namespace EHRNurse.Api.Interfaces
{
    public interface IInpatientService
    {
        // Xenis: This is the method for the main list (Monday's deadline)
        Task<IEnumerable<InpatientListItemDto>> GetAllInpatientsAsync();

        // Xenis: We will add the Medication method here later for Thursday's deadline
        // Task<MedicationDto> GetMedicationsForPatientAsync(int patientId, DateTime date);
    }
}