namespace EmploymentMonitoringSystem.Models
{
    public class EmploymentRecord
    {
        public int Id { get; set; }

        public string company_name { get; set; } = string.Empty;
        public string company_address { get; set; } = string.Empty;
        public string job_title { get; set; } = string.Empty;
        public string employment_status { get; set; } = string.Empty;
        public string hired_date { get; set; } = string.Empty;
        public string submitted_documents_date { get; set; } = string.Empty;
        public string interview_date { get; set; } = string.Empty;
        public string not_hired_reason { get; set; } = string.Empty;
    }
}
