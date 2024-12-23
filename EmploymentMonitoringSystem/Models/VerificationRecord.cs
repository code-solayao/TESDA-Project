namespace EmploymentMonitoringSystem.Models
{
    public class VerificationRecord
    {
        public int Id { get; set; }

        public string verification_means { get; set; } = string.Empty;
        public string verification_date { get; set; } = string.Empty;
        public string verification_status { get; set; } = string.Empty;
        public string follow_up_date_1 { get; set; } = string.Empty;
        public string follow_up_date_2 { get; set; } = string.Empty;
        public string response_status { get; set; } = string.Empty;
        public string not_interested_reason { get; set; } = string.Empty;
        public string referral_status { get; set; } = string.Empty;
        public string referral_date { get; set; } = string.Empty;
        public string no_referral_reason { get; set; } = string.Empty;
        public string invalid_contact { get; set; } = string.Empty;
    }
}
