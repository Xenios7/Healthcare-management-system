// using EHRNurse.Api.Dto;
// using EHRNurse.Api.Interfaces;
// using Microsoft.AspNetCore.Mvc;

// namespace EHRNurse.Api.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class NutritionController : ControllerBase
//     {
//         private readonly IInpatientService _inpatientService;

//         public NutritionController(IInpatientService inpatientService)
//         {
//             _inpatientService = inpatientService;
//         }

//         [HttpGet("schedule")]
//         public async Task<ActionResult<IEnumerable<NutritionListItemDto>>> GetNutritionSchedule(
//             [FromQuery] DateOnly date,
//             [FromQuery] string status = "all",
//             [FromQuery] string? search = null)
//         {
//             var result = await _inpatientService.GetNutritionScheduleAsync(date, status, search);
//             return Ok(result);
//         }
//     }
// }