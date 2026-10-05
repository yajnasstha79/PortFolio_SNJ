using System.ComponentModel.DataAnnotations;

namespace PortFolio_SNJ.Models;

public class Profile
{
    [Required]
    public string FullName { get; set; } = "";
    public List<string> Titles { get; set; } = new();   
    public string Summary { get; set; } = "";
    [Required]
    public string Email { get; set; } = "";
    [Required]
    public string? Phone { get; set; }
    [Required]
    public string Location { get; set; } = "";
    [Required]
    public string LinkedInUrl { get; set; } = "";
    [Required]
    public string? GitHubUrl { get; set; }
    //public string? PhotoUrl { get; set; }        
    public int YearsOfExperience { get; set; }
}
