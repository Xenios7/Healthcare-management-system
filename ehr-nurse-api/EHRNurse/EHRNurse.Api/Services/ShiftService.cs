using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using EHRNurse.Api.Dto;
using EHRNurse.Data;
using EHRNurse.Data.Models;
using EHRNurse.Api.Interfaces; 

namespace EHRNurse.Api.Services
{
    public class ShiftService : IShiftService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ShiftService> _logger;

        public ShiftService(AppDbContext context, ILogger<ShiftService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<ShiftResponseDto> ClockInAsync(Guid userId)
        {
            try
            {
                // 1. Find user by ID directly (Reliable lookup)
                var user = await _context.Users.FindAsync(userId);

                if (user == null)
                {
                    _logger.LogWarning($"Clock in failed: User with ID {userId} not found in DB.");
                    return null;
                }

                // 2. Check for active shift
                var activeShift = await _context.Shifts
                    .Where(s => s.UserId == user.Id && s.ClockOutTime == null)
                    .FirstOrDefaultAsync();

                if (activeShift != null)
                {
                    _logger.LogWarning($"User {user.Username} attempted to clock in while already clocked in.");
                    return MapToDto(activeShift, user); 
                }

                // 3. Create new shift
                var shift = new Shift
                {
                    UserId = user.Id,
                    ClockInTime = DateTime.UtcNow
                    // Removed 'IsActive = true' assignment to fix CS0200.
                    // The system determines 'Active' based on ClockOutTime being null.
                };

                _context.Shifts.Add(shift);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"User {user.Username} clocked in at {shift.ClockInTime}");

                return MapToDto(shift, user);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error during clock in for user {userId}: {ex.Message}");
                throw;
            }
        }

        public async Task<ShiftResponseDto> ClockOutAsync(Guid userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                if (user == null) return null;

                var activeShift = await _context.Shifts
                    .Where(s => s.UserId == user.Id && s.ClockOutTime == null)
                    .FirstOrDefaultAsync();

                if (activeShift == null)
                {
                    _logger.LogWarning($"User {user.Username} attempted to clock out without an active shift.");
                    return null;
                }

                activeShift.ClockOutTime = DateTime.UtcNow;
                // Removed 'activeShift.IsActive = false' assignment to fix CS0200.
                
                _context.Shifts.Update(activeShift);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"User {user.Username} clocked out at {activeShift.ClockOutTime}");

                return MapToDto(activeShift, user);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error during clock out for user {userId}: {ex.Message}");
                throw;
            }
        }

        public async Task<ShiftStatusDto> GetStatusAsync(Guid userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                if (user == null) return null;

                var activeShift = await _context.Shifts
                    .Where(s => s.UserId == user.Id && s.ClockOutTime == null)
                    .FirstOrDefaultAsync();

                return new ShiftStatusDto
                {
                    UserId = user.Id,
                    UserName = user.Username,
                    UserFullName = $"{user.FirstName} {user.LastName}",
                    IsCurrentlyClocked = activeShift != null,
                    CurrentClockInTime = activeShift?.ClockInTime,
                    Status = activeShift != null ? "Σε βάρδια" : "Εκτός βάρδιας"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting status for user {userId}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<ShiftResponseDto>> GetHistoryAsync(Guid userId, int pageNumber = 1, int pageSize = 10)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                if (user == null) return null;

                var shifts = await _context.Shifts
                    .Where(s => s.UserId == user.Id)
                    .OrderByDescending(s => s.ClockInTime)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                return shifts.Select(s => MapToDto(s, user)).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting history for user {userId}: {ex.Message}");
                throw;
            }
        }

        private ShiftResponseDto MapToDto(Shift shift, User user)
        {
            return new ShiftResponseDto
            {
                Id = shift.Id,
                UserId = shift.UserId,
                ClockInTime = shift.ClockInTime,
                ClockOutTime = shift.ClockOutTime,
                IsActive = shift.ClockOutTime == null, // Calculated property logic
                UserName = user.Username,
                UserFullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}