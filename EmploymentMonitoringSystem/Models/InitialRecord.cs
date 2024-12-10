using System.ComponentModel.DataAnnotations;

namespace EmploymentMonitoringSystem.Models
{
    public class InitialRecord
    {
        public int Id { get; set; }

        public string? District { get; set; }
        public string? City { get; set; }
        public string? TVI { get; set; }
        public string? Qualification_Title { get; set; }
        public string? Sector { get; set; }
        [Required] public string? Last_Name { get; set; }
        [Required] public string? First_Name { get; set; }
        public string? Middle_Name { get; set; }
        public string? Extension_Name { get; set; }
        public string? Full_Name { get; set; }
        public string? Sex { get; set; }
        public string? Birthdate { get; set; }
        public string? Contact_Number { get; set; }
        public string? Email { get; set; }
        public string? Scholarship_Type { get; set; }
        public string? Address { get; set; }
        public string? Allocation { get; set; }

        public InitialRecord() { }
    }
}
