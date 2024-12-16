namespace EmploymentMonitoringSystem.Models
{
    public class ExternalRecord
    {
        public int Id { get; set; }

        public string? training_status { get; set; }
        public string? assessment_result { get; set; }
        public string? employment_before_training { get; set; }
        public string? occupation { get; set; }
        public string? employer_name { get; set; }
        public string? employment_type { get; set; }
        public string? date_hired { get; set; }
        public string? remarks { get; set; }
        public string? count { get; set; }
        public string? no_of_graduates { get; set; }
        public string? no_of_employed { get; set; }
        public string? verification { get; set; }
        public string? job_vacancies { get; set; }
    }
}
