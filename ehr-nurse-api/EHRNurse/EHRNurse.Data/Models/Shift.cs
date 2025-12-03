using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHRNurse.Data.Models
{
    [Table("shifts")]
    public class Shift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Required]
        [Column("clock_in_time")]
        public DateTime ClockInTime { get; set; }

        [Column("clock_out_time")]
        public DateTime? ClockOutTime { get; set; }

        [NotMapped]
        public bool IsActive => ClockOutTime == null;
    }
}