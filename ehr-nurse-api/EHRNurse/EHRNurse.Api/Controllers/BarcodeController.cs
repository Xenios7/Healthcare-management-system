using EHRNurse.Api.Dto;
using EHRNurse.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EHRNurse.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BarcodeController : ControllerBase
    {
        private readonly IBarcodeService _barcodeService;

        public BarcodeController(IBarcodeService barcodeService)
        {
            _barcodeService = barcodeService;
        }

        [HttpPost("scan")]
        public async Task<IActionResult> ScanBarcode([FromBody] BarcodeRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.BarcodeData))
                return BadRequest(new { message = "BarcodeData cannot be empty" });

            var result = await _barcodeService.ProcessBarcodeAsync(request.BarcodeData);

            return result.Success ? Ok(result) : NotFound(result);
        }
    }
}
