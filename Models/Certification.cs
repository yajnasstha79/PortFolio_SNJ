namespace PortFolio_SNJ.Models
{
    public class Certification
    {
        public string Name { get; set; } = "";
        public string Issuer { get; set; } = "";
        public int Year { get; set; }
        public string? Description { get; set; }
    }
}
