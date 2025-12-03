using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EHRNurse.Api.Dto;
using EHRNurse.Api.Services;
using System.Security.Claims;

namespace EHRNurse.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] 
    public class ShiftController : ControllerBase
    {
        private readonly IShiftService _shiftService;
        private readonly ILogger<ShiftController> _logger;

        public ShiftController(IShiftService shiftService, ILogger<ShiftController> logger)
        {
            _shiftService = shiftService;
            _logger = logger;
        }

      
        private Guid? GetCurrentUserId()
        {
            // 1. Look for standard "NameIdentifier" claim (which holds the ID)
            var idClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            // 2. Try to parse it as a GUID
            if (Guid.TryParse(idClaim, out var userId))
            {
                return userId;
            }
            
            // 3. Fallback: Try "sub" claim just in case
            var subClaim = User.FindFirst("sub")?.Value;
            if (Guid.TryParse(subClaim, out var subId))
            {
                return subId;
            }
            
            _logger.LogWarning("Token present but could not extract User ID (NameIdentifier or sub) as Guid.");
            return null;
        }

        [HttpPost("clock-in")]
        public async Task<IActionResult> ClockIn() // No arguments needed from Frontend body
        {
            var userId = GetCurrentUserId();
            if (userId == null) return Unauthorized(new { message = "Invalid User Token." });

            try
            {
                // Pass the Guid userId to the service
                var result = await _shiftService.ClockInAsync(userId.Value);

                if (result == null)
                    return BadRequest(new { message = "Failed to clock in." });

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error during clock in: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred during clock in.", error = ex.Message });
            }
        }

        [HttpPost("clock-out")]
        public async Task<IActionResult> ClockOut() // No arguments needed
        {
            var userId = GetCurrentUserId();
            if (userId == null) return Unauthorized(new { message = "Invalid User Token." });

            try
            {
                // Pass the Guid userId to the service
                var result = await _shiftService.ClockOutAsync(userId.Value);

                if (result == null)
                    return BadRequest(new { message = "Failed to clock out. User either doesn't exist or has no active shift." });

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error during clock out: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred during clock out.", error = ex.Message });
            }
        }

        [HttpGet("status")]
        public async Task<IActionResult> GetStatus()
        {
            var userId = GetCurrentUserId();
            if (userId == null) return Unauthorized(new { message = "Invalid User Token." });

            try
            {
                // Pass the Guid userId to the service
                var result = await _shiftService.GetStatusAsync(userId.Value);

                if (result == null)
                    return NotFound(new { message = "User record not found." });

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error while retrieving shift status: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred while retrieving shift status.", error = ex.Message });
            }
        }

        [HttpGet("history")]
        public async Task<IActionResult> GetHistory(int pageNumber = 1, int pageSize = 10)
        {
            var userId = GetCurrentUserId();
            if (userId == null) return Unauthorized(new { message = "Invalid User Token." });

            if (pageNumber < 1)
                return BadRequest(new { message = "Page number must be greater than 0." });

            if (pageSize < 1 || pageSize > 100)
                return BadRequest(new { message = "Page size must be between 1 and 100." });

            try
            {
                // Pass the Guid userId to the service
                var result = await _shiftService.GetHistoryAsync(userId.Value, pageNumber, pageSize);

                // Return empty list instead of 404 if simply no history exists yet
                return Ok(result ?? new List<ShiftResponseDto>());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error while retrieving shift history: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred while retrieving shift history.", error = ex.Message });
            }
        }
    }
}