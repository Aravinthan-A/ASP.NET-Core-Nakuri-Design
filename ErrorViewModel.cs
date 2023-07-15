namespace Nakuri.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string Name { get; set; }
        public string Email { get; set; }
        public int Pass { get; set; }
        public int Phone { get; set; }
    }
}