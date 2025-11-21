public class NutritionListItemDto
{
    public int FoodId { get; set; }
    public int PatientId { get; set; }

    public string PatientName { get; set; } = null!;
    public int? PatientAge { get; set; }

    public string Ward { get; set; } = "";
    public string Bed { get; set; } = "";
    public int DaysInWard { get; set; }

    public string MealType { get; set; } = "";     // Breakfast / Lunch / Dinner / Snack
    public string MealName { get; set; } = "";      // Description becomes name
    public string? Instructions { get; set; }

    public int? PortionSize { get; set; }
    public int? PortionEatenPercentage { get; set; }

    public string Status { get; set; } = "not_given"; // same as medication
    public bool HasReminder { get; set; } = false;
}
