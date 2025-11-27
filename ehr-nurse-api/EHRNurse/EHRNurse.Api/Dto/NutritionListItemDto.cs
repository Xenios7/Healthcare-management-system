namespace EHRNurse.Api.Dto
{
    public class NutritionListItemDto
    {
        public int FoodId { get; set; }
        public int PatientId { get; set; }

        public string PatientName { get; set; } = null!;
        public int? PatientAge { get; set; }

        public string Ward { get; set; } = null!;
        public string Bed { get; set; } = null!;
        public int DaysInWard { get; set; }

        // Food-specific fields from FoodDatum
        public string FoodType { get; set; } = null!;
        public string? FoodTypeCode { get; set; }
        public int? PortionEatenPercentage { get; set; }
        public int? PortionSize { get; set; }
        public string? Description { get; set; }

        public DateTime OnSetDateTime { get; set; }
        public string Status { get; set; } = "pending";
        public bool HasAllergyWarning { get; set; }
    }
}