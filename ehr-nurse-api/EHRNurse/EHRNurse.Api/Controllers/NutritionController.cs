using EHRNurse.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EHRNurse.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NutritionController : ControllerBase
    {
        private readonly IInpatientService _inpatientService;

        public NutritionController(IInpatientService inpatientService)
        {
            _inpatientService = inpatientService;
        }

        /// Get nutrition for a specific patient
        [HttpGet("patient/{patientId}")]
        public async Task<IActionResult> GetNutritionForPatient(
            int patientId,
            [FromQuery] DateOnly date,
            [FromQuery] string status = "all")
        {
            try
            {
                var nutrition = await _inpatientService.GetNutritionForPatientAsync(patientId, date, status);
                return Ok(nutrition);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}