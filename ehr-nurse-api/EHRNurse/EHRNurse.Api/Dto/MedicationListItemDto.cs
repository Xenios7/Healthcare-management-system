public class MedicationListItemDto
{
    public int MedicationId { get; set; }
    public int PatientId { get; set; }

    public string PatientName { get; set; } = null!;
    public int? PatientAge { get; set; }   // ← here

    public string Ward { get; set; } = null!;
    public string Bed { get; set; } = null!;
    public int DaysInWard { get; set; }

    public string ProductName { get; set; } = null!;
    public string? Form { get; set; }
    public double Quantity { get; set; }
    public string QuantityUnit { get; set; } = null!;
    public double FrequencyAmount { get; set; }
    public string FrequencyUnit { get; set; } = null!;
    public double DurationAmount { get; set; }
    public string DurationUnit { get; set; } = null!;
    public string? Route { get; set; }

    public string? InstructionPatient { get; set; }
    public DateTime? EndDate { get; set; }
    public string Status { get; set; } = "not_given";
    public bool HasReminder { get; set; }

}
