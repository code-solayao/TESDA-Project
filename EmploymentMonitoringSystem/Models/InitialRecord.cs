using System.ComponentModel.DataAnnotations;

namespace EmploymentMonitoringSystem.Models
{
    public class InitialRecord
    {
        public int Id { get; set; }

        public string? district { get; set; }
        public string? city { get; set; }
        public string? tvi { get; set; }
        public string? qualification_title { get; set; }
        public string? sector { get; set; }
        [Required(ErrorMessage = "Please enter a last name.")] 
        public string last_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a first name.")] 
        public string first_name { get; set; } = string.Empty;
        public string? middle_name { get; set; }
        public string? extension_name { get; set; }
        public string? full_name { get; set; }
        public string? sex { get; set; }
        public string? birthdate { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Contact number must have 11 digits.")]
        public string? contact_number { get; set; }
        public string? email { get; set; }
        public string? scholarship_type { get; set; }
        public string? address { get; set; }
        public string? allocation { get; set; }
    }
}
