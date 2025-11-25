using EHRNurse.Api.Dto;

namespace EHRNurse.Api.Interfaces
{
    public interface IInpatientService
    {
        Task<IEnumerable<InpatientListItemDto>> GetAllInpatientsAsync();
        Task<IEnumerable<MedicationListItemDto>> GetMedicationsForPatientAsync(int patientId, DateOnly date);
    }
}