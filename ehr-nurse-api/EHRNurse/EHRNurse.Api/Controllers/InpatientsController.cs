using Microsoft.AspNetCore.Mvc;
using EHRNurse.Api.Dto;
using EHRNurse.Api.Interfaces;

namespace EHRNurse.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Maps to: /api/inpatients
    public class InpatientsController : ControllerBase
    {
        private readonly IInpatientService _inpatientService;

        // Constructor Injection: We inject the service here
        public InpatientsController(IInpatientService inpatientService)
        {
            _inpatientService = inpatientService;
        }

        // GET: api/inpatients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InpatientListItemDto>>> GetInpatients()
        {
            var patients = await _inpatientService.GetAllInpatientsAsync();
            return Ok(patients);
        }

        [HttpGet("{id}/medication")]
        public async Task<ActionResult<IEnumerable<MedicationListItemDto>>> GetPatientMedications(int id)
        {
            var meds = await _inpatientService.GetMedicationsForPatientAsync(id);
            
            // If no meds found, we can still return an empty list
            return Ok(meds);
        }
    }
}