namespace Git_Uppgift.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string? Error { get; set; } //test
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}