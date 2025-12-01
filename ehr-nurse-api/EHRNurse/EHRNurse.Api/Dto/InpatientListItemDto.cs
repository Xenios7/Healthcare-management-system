public class InpatientListItemDto
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string WardId { get; set; }
    public required string Diagnosis { get; set; }
    
    public int PatientId { get; set; }
    public int Age { get; set; }
    public bool HasPendingMeds { get; set; }
    public bool HasPendingMeals { get; set; }
}