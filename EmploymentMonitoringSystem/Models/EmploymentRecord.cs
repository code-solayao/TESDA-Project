namespace EmploymentMonitoringSystem.Models
{
    public class EmploymentRecord
    {
        public int Id { get; set; }

        public string? company_name { get; set; }
        public string? company_address { get; set; }
        public string? job_title { get; set; }
        public string? employment_status { get; set; }
        public string? hired_date { get; set; }
        public string? submitted_documents_date { get; set; }
        public string? interview_date { get; set; }
        public string? not_hired_reason { get; set; }
    }
}
