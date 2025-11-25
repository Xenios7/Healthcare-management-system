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
            [FromQuery] DateOnly? date,
            [FromQuery] string? status = "all") // Default to "all" if missing
        {
            var queryDate = date ?? DateOnly.FromDateTime(DateTime.Now);
            
            // Pass the status to the service
            var meds = await _inpatientService.GetMedicationsForPatientAsync(id, queryDate, status ?? "all");
            
            return Ok(meds);
        }
    }
}