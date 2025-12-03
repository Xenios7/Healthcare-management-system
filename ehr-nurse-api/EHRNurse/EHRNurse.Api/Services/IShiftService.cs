using EHRNurse.Api.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EHRNurse.Api.Services
{
    public interface IShiftService
    {
        // We now use Guid userId (from the token) instead of string username
        Task<ShiftResponseDto> ClockInAsync(Guid userId);

        Task<ShiftResponseDto> ClockOutAsync(Guid userId);

        Task<ShiftStatusDto> GetStatusAsync(Guid userId);

        Task<IEnumerable<ShiftResponseDto>> GetHistoryAsync(Guid userId, int pageNumber, int pageSize);
    }
}