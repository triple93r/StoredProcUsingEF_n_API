using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoredProcinAPI.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; } = string.Empty!;
        public string? LastName { get; set; } = string.Empty;
        public string? Age { get; set; } = string.Empty;
        public string? Adrress { get; set; } = string.Empty;
        public string? PatientType { get; set; } = string.Empty;
        public string? bednum { get; set; } = string.Empty;
        public string? diagnosis { get; set; } = string.Empty;

        [NotMapped]
        public string? ttype { get; set; } = string.Empty;
    }
}
