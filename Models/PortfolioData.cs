using System.Collections.Generic;

namespace PortFolio_SNJ.Models
{
    public class PortfolioData
    {
        public Profile Profile { get; set; } = new();
        public List<Experience> Experience { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<SkillCategory> SkillCategories { get; set; } = new();
        public List<Education> Education { get; set; } = new();
        public List<Certification> Certifications { get; set; } = new();
    }
}
