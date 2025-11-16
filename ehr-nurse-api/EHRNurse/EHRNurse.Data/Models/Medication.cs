namespace EHRNurse.Data.Models
{
    public class Medication
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
