using System.ComponentModel.DataAnnotations;

namespace EmploymentMonitoringSystem.Models
{
    public class Graduate
    {
        public int Id { get; set; }

        public string? district { get; set; }
        public string? city { get; set; }
        public string? tvi { get; set; }
        public string? qualification_title { get; set; }
        public string? sector { get; set; }
        [Required(ErrorMessage = "Please enter a last name.")]
        public string? last_name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a first name.")]
        public string? first_name { get; set; } = string.Empty;
        public string? middle_name { get; set; }
        public string? extension_name { get; set; }
        public string? full_name { get; set; }
        public string? sex { get; set; }
        public string? birthdate { get; set; }
        [StringLength(16, MinimumLength = 13, ErrorMessage = "Please follow the format for Contact Number: <b>0900-000-0000</b>")]
        public string? contact_number { get; set; }
        public string? email { get; set; }
        public string? scholarship_type { get; set; }
        public string? address { get; set; }
        public string? allocation { get; set; }

        public string? verification_means { get; set; }
        public string? verification_date { get; set; }
        public string? verification_status { get; set; }
        public string? follow_up_date_1 { get; set; }
        public string? follow_up_date_2 { get; set; }
        public string? response_status { get; set; }
        public string? not_interested_reason { get; set; }
        public string? referral_status { get; set; }
        public string? referral_date { get; set; }
        public string? no_referral_reason { get; set; }
        public string? invalid_contact { get; set; }

        public string? company_name { get; set; }
        public string? company_address { get; set; }
        public string? job_title { get; set; }
        public string? employment_status { get; set; }
        public string? hired_date { get; set; }
        public string? submitted_documents_date { get; set; }
        public string? interview_date { get; set; }
        public string? not_hired_reason { get; set; }

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
