using System.ComponentModel.DataAnnotations;

namespace EmploymentMonitoringSystem.Models
{
    public class InitialRecord
    {
        public int Id { get; set; }

        public string district { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string tvi { get; set; } = string.Empty;
        public string qualification_title { get; set; } = string.Empty;
        public string sector { get; set; } = string.Empty;
        [Required] 
        public string last_name { get; set; } = string.Empty;
        [Required] 
        public string first_name { get; set; } = string.Empty;
        public string middle_name { get; set; } = string.Empty;
        public string extension_name { get; set; } = string.Empty;
        public string full_name { get; set; } = string.Empty;
        public string sex { get; set; } = string.Empty;
        public string birthdate { get; set; } = string.Empty;
        public string contact_number { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string scholarship_type { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string allocation { get; set; } = string.Empty;
    }
}
