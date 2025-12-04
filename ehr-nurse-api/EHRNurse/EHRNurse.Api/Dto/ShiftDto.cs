using System;
using System.ComponentModel.DataAnnotations;

namespace EHRNurse.Api.Dto
{
    public class ShiftRequestDto
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Username must be between 1 and 255 characters")]
        public string Username { get; set; }
    }

    public class ShiftResponseDto
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime ClockInTime { get; set; }

        public DateTime? ClockOutTime { get; set; }

        public bool IsActive { get; set; }

        public string? UserName { get; set; }

        public string? UserFullName { get; set; }

        public TimeSpan? ShiftDuration
        {
            get
            {
                if (ClockOutTime.HasValue)
                {
                    return ClockOutTime.Value - ClockInTime;
                }
                return null;
            }
        }
    }

    public class ShiftStatusDto
    {
        public Guid UserId { get; set; }

        public bool IsCurrentlyClocked { get; set; }

        public DateTime? CurrentClockInTime { get; set; }

        public string? Status { get; set; } 

        public string? UserName { get; set; }

        public string? UserFullName { get; set; }
    }
}