using System.ComponentModel.DataAnnotations;

namespace CrimeRecordsSystem.Models
{
    public class Officer
    {
        [Key]
        public int OfficerId { get; set; }
        
        [Required(ErrorMessage = "Badge Number is mandatory.")]
        public string BadgeNumber { get; set; } = string.Empty;
        
        [Required]
        public string Password { get; set; } = string.Empty; 
        
        public string Name { get; set; } = string.Empty;
        public string Station { get; set; } = string.Empty;
    }
}