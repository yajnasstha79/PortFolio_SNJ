using System.ComponentModel.DataAnnotations;

namespace PortFolio_SNJ.Models
{
    public class Experience
    {
        [Required]
        public string Role { get; set; } = "";
        public string Company { get; set; } = "";
        public string Location { get; set; } = "";
        public string? WorkMode { get; set; }               // "Remote", "On-site"
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }              // null = Present
        public List<string> Highlights { get; set; } = new();
        public List<string> Tech { get; set; } = new();

        public bool IsCurrent => EndDate is null;
        public string Period =>
            $"{StartDate:MMM yyyy} – {(EndDate is null ? "Present" : EndDate.Value.ToString("MMM yyyy"))}";
    }
}
