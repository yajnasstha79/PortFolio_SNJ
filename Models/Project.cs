using System.ComponentModel.DataAnnotations;

namespace PortFolio_SNJ.Models
{
    public class Project
    {          
        [Required]
        public string Title { get; set; } = "";
        public string? Client { get; set; }       
        public string Category { get; set; } = "";
        public string Summary { get; set; } = "";  
        public List<string> Highlights { get; set; } = new(); 
        public List<string> Tech { get; set; } = new();
    }
}
