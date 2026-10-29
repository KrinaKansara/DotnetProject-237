using System.ComponentModel.DataAnnotations;

namespace CrimeRecordsSystem.Models
{
    public class Criminal
    {
        [Key]
        public int CriminalId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        // Secure tracking of identity documents
        [Required]
        [RegularExpression(@"^\d{12}$", ErrorMessage = "Valid 12-digit ID required.")]
        public string AadharNumber { get; set; } = string.Empty;

        // The ? tells the compiler these are allowed to be empty
        public string? PhysicalDescription { get; set; }
        public string? KnownOffenses { get; set; }
    }
}