using System.ComponentModel.DataAnnotations;
using System;

namespace CrimeRecordsSystem.Models
{
    public class FIR
    {
        [Key]
        public int FirId { get; set; }

        [Required(ErrorMessage = "Victim Name is required.")]
        public string VictimName { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid Indian Phone Number.")]
        public string ContactNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Police Station (Thana) is required.")]
        public string PoliceStation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Select the type of crime.")]
        public string CrimeType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Applicable IPC/BNS Section is required.")]
        public string LegalSection { get; set; } = string.Empty;

        [Required]
        public string IncidentDetails { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime IncidentDate { get; set; }

        public string? Status { get; set; } = "Under Investigation"; 
        
        public int OfficerId { get; set; }
        public Officer? InvestigatingOfficer { get; set; }
    }
}