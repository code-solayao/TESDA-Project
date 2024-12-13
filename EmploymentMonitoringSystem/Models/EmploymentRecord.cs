namespace EmploymentMonitoringSystem.Models
{
    public class EmploymentRecord
    {
        public int Id { get; set; }

        public string? Company_Name { get; set; }
        public string? Company_Address { get; set; }
        public string? Job_Title { get; set; }
        public string? Employment_Status { get; set; }
        public string? Hired_Date { get; set; }
        public string? Submitted_Documents_Date { get; set; }
        public string? Interview_Date { get; set; }
        public string? Not_Hired_Reason { get; set; }
    }
}
