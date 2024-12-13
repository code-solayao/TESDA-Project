namespace EmploymentMonitoringSystem.Models
{
    public class ExternalRecord
    {
        public int Id { get; set; }

        public string? Training_Status { get; set; }
        public string? Assessment_Result { get; set; }
        public string? Employment_Before_Training { get; set; }
        public string? Occupation { get; set; }
        public string? Employer_Name { get; set; }
        public string? Employment_Type { get; set; }
        public string? Date_Hired { get; set; }
        public string? Remarks { get; set; }
        public string? Count { get; set; }
        public string? No_Of_Graduates { get; set; }
        public string? No_Of_Employed { get; set; }
        public string? Verification { get; set; }
        public string? Job_Vacancies { get; set; }

        public ExternalRecord() { }
    }
}
