using Microsoft.AspNetCore.Mvc;
using EHRNurse.Api.Dto;
using EHRNurse.Api.Interfaces;

namespace EHRNurse.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InpatientsController : ControllerBase
    {
        private readonly IInpatientService _inpatientService;

        public InpatientsController(IInpatientService inpatientService)
        {
            _inpatientService = inpatientService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InpatientListItemDto>>> GetInpatients()
        {
            var patients = await _inpatientService.GetAllInpatientsAsync();
            return Ok(patients);
        }

        // UPDATED: Added [FromQuery] to read the date from the URL
        [HttpGet("{id}/medication")]
        public async Task<ActionResult<IEnumerable<MedicationListItemDto>>> GetPatientMedications(
            int id, 
            [FromQuery] DateOnly? date) // Nullable allows it to work even if frontend forgets the date
        {
            // If date is missing, default to Today
            var queryDate = date ?? DateOnly.FromDateTime(DateTime.Now);

            var meds = await _inpatientService.GetMedicationsForPatientAsync(id, queryDate);
            return Ok(meds);
        }
    }
}