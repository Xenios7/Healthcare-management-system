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

        [HttpGet("{id}/medication")]
        public async Task<ActionResult<IEnumerable<MedicationListItemDto>>> GetPatientMedications(
            int id, 
            [FromQuery] DateOnly? date,
            [FromQuery] string? status = "all")
        {
            var queryDate = date ?? DateOnly.FromDateTime(DateTime.Now);
            var meds = await _inpatientService.GetMedicationsForPatientAsync(id, queryDate, status ?? "all");
            return Ok(meds);
        }

        // --- ADDED THIS MISSING ENDPOINT ---
        [HttpGet("{id}/nutrition")]
        public async Task<ActionResult<IEnumerable<NutritionListItemDto>>> GetPatientNutrition(
            int id, 
            [FromQuery] DateOnly? date,
            [FromQuery] string? status = "all")
        {
            var queryDate = date ?? DateOnly.FromDateTime(DateTime.Now);
            // This calls the method you just showed me in your service
            var nutrition = await _inpatientService.GetNutritionForPatientAsync(id, queryDate, status ?? "all");
            return Ok(nutrition);
        }
    }
}