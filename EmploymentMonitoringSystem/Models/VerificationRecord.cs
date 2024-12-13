namespace EmploymentMonitoringSystem.Models
{
    public class VerificationRecord
    {
        public int Id { get; set; }

        public string? Verification_Means { get; set; }
        public string? Verification_Date { get; set; }
        public string? Verification_Status { get; set; }
        public string? Follow_Up_Date_1 { get; set; }
        public string? Follow_Up_Date_2 { get; set; }
        public string? Response_Status { get; set; }
        public string? Not_Interested_Reason { get; set; }
        public string? Referral_Status { get; set; }
        public string? Referral_Date { get; set; }
        public string? No_Referral_Reason { get; set; }
        public string? Invalid_Contact { get; set; }

        public VerificationRecord() { }
    }
}
