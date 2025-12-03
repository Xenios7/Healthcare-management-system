namespace EHRNurse.Api.Models
{
    public class AppointmentPatientDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Comments { get; set; }
        public DateTime StartDate { get; set; }

        public bool IsRejected { get; set; }

        public int PatientId { get; set; }
        public Guid? DoctorId { get; set; }

        public string? StatusCode { get; set; }
        public string? StatusDisplay { get; set; }
    }

    public class UpdateAppointmentStatusRequest
    {
        public string StatusCode { get; set; } = null!;
    }
}