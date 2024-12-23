namespace EmploymentMonitoringSystem.Models
{
    public class ExternalRecord
    {
        public int Id { get; set; }

        public string training_status { get; set; } = string.Empty;
        public string assessment_result { get; set; } = string.Empty;
        public string employment_before_training { get; set; } = string.Empty;
        public string occupation { get; set; } = string.Empty;
        public string employer_name { get; set; } = string.Empty;
        public string employment_type { get; set; } = string.Empty;
        public string date_hired { get; set; } = string.Empty;
        public string remarks { get; set; } = string.Empty;
        public string count { get; set; } = string.Empty;
        public string no_of_graduates { get; set; } = string.Empty;
        public string no_of_employed { get; set; } = string.Empty;
        public string verification { get; set; } = string.Empty;
        public string job_vacancies { get; set; } = string.Empty;
    }
}
