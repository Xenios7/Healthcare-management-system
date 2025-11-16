namespace EHRNurse.Api.Dto
{
    public class BarcodeResponse
    {
        public bool Success { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public object? Data { get; set; }
    }
}
