using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmUpdate : Form
    {
        public int Id { get; set; }

        private string _verification_means;
        private string _verification_date;
        private string _verification_status;

        private string _response_type;
        private bool _refer_to_company;
        private string _referral_date;
        private string _no_referral_reason;
        private string _not_interested_reason;

        private string _follow_up_date_1;
        private string _follow_up_date_2;
        private bool _invalid_contact;

        private string _company_name;
        private string _address;
        private string _job_title;

        private string _employment_status;
        private string _hired_date;
        private string _submitted_documents_date;
        private string _for_interview_date;
        private string _not_hired_reason;

        private FrmRecords _frmRecords;

        private List<DateTimePicker> _dateTimePickers;

        public FrmUpdate(FrmRecords frmRecords)
        {
            InitializeComponent();

            _frmRecords = frmRecords;

            grpNoResponse.Location = grpResponded.Location;

            _dateTimePickers = new List<DateTimePicker>
            {
                dtDateVerify,
                dtReferCompany,
                dtDateFollowup1,
                dtDateFollowup2,
                dtHired,
                dtSubmitDocs,
                dtForInterview
            };

            InitialiseClearDetails();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            LoadDetails();
            RetrieveVerificationRecord();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = "Do you wish to update this information?";
            DialogResult result = MessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpdateDatabaseTable();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure to cancel this process?";
            DialogResult result = MessageBox.Show(message, "Cancel Update", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        #region Radio Button Actions

        // Verification tab page
        private void rbtnResponded_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnResponded.Checked)
            {
                grpResponded.Visible = true;
            }
            else
            {
                grpResponded.Visible = false;

                rbtnInterested.Checked = false;
                rbtnNotInterested.Checked = false;

                grpReferralStatus.Enabled = false;
                rbtnYes.Checked = false;
                rbtnNo.Checked = false;
                dtReferCompany.Enabled = false;
                rtbRsnReferralNo.Clear();
                rtbRsnReferralNo.Enabled = false;

                rtbRsnNotInterested.Clear();
                grpRsnNotInterested.Enabled = false;
            }
        }

        private void rbtnNoResponse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNoResponse.Checked)
            {
                grpNoResponse.Visible = true;

                dtDateFollowup1.Enabled = true;
                dtDateFollowup2.Enabled = true;
            }
            else
            {
                grpResponded.Visible = false;

                dtDateFollowup1.Enabled = false;
                dtDateFollowup2.Enabled = false;
                chkInvalidContact.Checked = false;
            }
        }

        private void rbtnInterested_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInterested.Checked)
            {
                grpReferralStatus.Enabled = true;
            }
            else
            {
                grpReferralStatus.Enabled = false;

                rbtnYes.Checked = false;
                rbtnNo.Checked = false;

                dtReferCompany.Enabled = false;
                rtbRsnReferralNo.Clear();
                rtbRsnReferralNo.Enabled = false;
            }
        }

        private void rbtnNotInterested_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNotInterested.Checked)
            {
                grpRsnNotInterested.Enabled = true;
            }
            else
            {
                grpRsnNotInterested.Enabled = false;
                rtbRsnNotInterested.Clear();
            }
        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)
            {
                dtReferCompany.Enabled = true;
                EmploymentTabPageAction(true);
            }
            else
            {
                dtReferCompany.Enabled = false;
                EmploymentTabPageAction(false);
            }
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNo.Checked)
            {
                rtbRsnReferralNo.Enabled = true;
            }
            else
            {
                rtbRsnReferralNo.Enabled = false;
                rtbRsnReferralNo.Clear();
            }
        }

        // Employment tab page
        private void rbtnHired_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHired.Checked) dtHired.Enabled = true;
            else dtHired.Enabled = false;
        }

        private void rbtnSubmitDocs_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSubmitDocs.Checked) dtSubmitDocs.Enabled = true;
            else dtSubmitDocs.Enabled = false;
        }

        private void rbtnForInterview_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnForInterview.Checked) dtForInterview.Enabled = true;
            else dtForInterview.Enabled = false;
        }

        private void rbtnNotHired_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNotHired.Checked) cbxRsnNotHired.Enabled = true;
            else cbxRsnNotHired.Enabled = false;
        }

        #endregion

        #region Functions

        private void InitialiseClearDetails()
        {
            List<Label> _detailsLabels = new List<Label>
            {
                lblLastName,
                lblFirstName,
                lblMiddleName,
                lblExtnName,
                lblSex,
                lblBirthDate,
                lblContactNum,
                lblAddress,
                lblEmail,
                lblSector,
                lblQualiTitle,
                lblDistrict,
                lblCity,
                lblScholarType,
                lblTVI,
                lblGradYear
            };

            foreach (Label detail in _detailsLabels)
            {
                detail.Text = string.Empty;
            }
        }

        private void LoadDetails()
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = $"SELECT * FROM {Utilities.DbTable} WHERE id = @id";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lblLastName.Text = reader.GetString(1);
                        lblFirstName.Text = reader.GetString(2);
                        lblMiddleName.Text = reader.GetString(3);
                        lblExtnName.Text = reader.GetString(4);
                        lblSex.Text = reader.GetString(5);
                        lblBirthDate.Text = DateOfBirthFormat(reader.GetDateTime(6));
                        lblContactNum.Text = reader.GetString(7);
                        lblAddress.Text = reader.GetString(8);
                        lblEmail.Text = reader.GetString(9);
                        lblSector.Text = reader.GetString(10);
                        lblQualiTitle.Text = reader.GetString(11);
                        lblTVI.Text = reader.GetString(12);
                        lblDistrict.Text = reader.GetString(13);
                        lblCity.Text = reader.GetString(14);
                        lblScholarType.Text = reader.GetString(15);
                        lblGradYear.Text = reader.GetInt32(16).ToString();
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        private void RetrieveVerificationRecord()
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "CALL retrieve_verification_record(@id);";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbxMeansVerify.Text = reader.GetString(0);
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        private string DateOfBirthFormat(DateTime readerDateTime)
        {
            string monthName = string.Empty;
            int month = readerDateTime.Month;
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;

                case 2:
                    monthName = "February";
                    break;

                case 3:
                    monthName = "March";
                    break;

                case 4:
                    monthName = "April";
                    break;

                case 5:
                    monthName = "May";
                    break;

                case 6:
                    monthName = "June";
                    break;

                case 7:
                    monthName = "July";
                    break;

                case 8:
                    monthName = "August";
                    break;

                case 9:
                    monthName = "September";
                    break;

                case 10:
                    monthName = "October";
                    break;

                case 11:
                    monthName = "November";
                    break;

                case 12:
                    monthName = "December";
                    break;

                default:
                    monthName = "";
                    break;
            }

            string format = $"{monthName} {readerDateTime.Day}, {readerDateTime.Year}";
            return format;
        }

        private void UpdateDatabaseTable()
        {
            CustomiseDateTimePickers(true);

            // Verification tab page
            _verification_means = cbxMeansVerify.Text;
            _verification_date = dtDateVerify.Text;
            _verification_status = Value_VerificationStatus();

            _response_type = Value_TypeOfResponse();
            _refer_to_company = Value_ReferToCompany();
            _referral_date = Value_ReferralDate();
            _no_referral_reason = rtbRsnReferralNo.Text;
            _not_interested_reason = rtbRsnNotInterested.Text;

            _follow_up_date_1 = Value_FollowUpDate_1();
            _follow_up_date_2 = Value_FollowUpDate_2();
            _invalid_contact = chkInvalidContact.Checked;

            // Employment tab page
            _company_name = txtCompanyName.Text;
            _address = rtbAddress.Text;
            _job_title = txtJobTitle.Text;

            _employment_status = Value_EmploymentStatus();
            _hired_date = Value_HiredDate();
            _submitted_documents_date = Value_SubmittedDocumentsDate();
            _for_interview_date = Value_ForInterviewDate();
            _not_hired_reason = cbxRsnNotHired.Text;

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = $"CALL update_verification_record(@id, @means, @date, @status, @response_type, @can_refer, " +
                        $"{_referral_date}, @no_ref_rsn, @not_interested_rsn, {_follow_up_date_1}, {_follow_up_date_2}, @invalid_contact);";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@means", _verification_means);
                    command.Parameters.AddWithValue("@date", _verification_date);
                    command.Parameters.AddWithValue("@status", _verification_status);
                    command.Parameters.AddWithValue("@response_type", _response_type);
                    command.Parameters.AddWithValue("@can_refer", _refer_to_company);
                    command.Parameters.AddWithValue("@no_ref_rsn", _no_referral_reason);
                    command.Parameters.AddWithValue("@not_interested_rsn", _not_interested_reason);
                    command.Parameters.AddWithValue("@invalid_contact", _invalid_contact);
                    command.ExecuteNonQuery();

                    sql = $"CALL update_employment_record(@id, @company_name, @address, @job_title, @employment_status, {_hired_date}, " +
                        $"{_submitted_documents_date}, {_for_interview_date}, @not_hired_reason);";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@company_name", _company_name);
                    command.Parameters.AddWithValue("@address", _address);
                    command.Parameters.AddWithValue("@job_title", _job_title);
                    command.Parameters.AddWithValue("@employment_status", _employment_status);
                    command.Parameters.AddWithValue("@hired_date", _hired_date);
                    command.Parameters.AddWithValue("@submit_docs_date", _submitted_documents_date);
                    command.Parameters.AddWithValue("@interview_date", _for_interview_date);
                    command.Parameters.AddWithValue("@not_hired_reason", _not_hired_reason);
                    command.ExecuteNonQuery();

                    CustomiseDateTimePickers(false);

                    _frmRecords.RefreshAllRecords();
                    MessageBox.Show("The information was updated successfully.");

                    Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CustomiseDateTimePickers(bool canCustomise)
        {
            if (canCustomise)
            {
                foreach (DateTimePicker dtPicker in _dateTimePickers)
                {
                    dtPicker.Format = DateTimePickerFormat.Custom;
                    dtPicker.CustomFormat = "yyyy-MM-dd";
                }
            }
            else
            {
                foreach (DateTimePicker dtPicker in _dateTimePickers)
                {
                    dtPicker.Format = DateTimePickerFormat.Long;
                }
            }
        }

        private void EmploymentTabPageAction(bool isActive)
        {
            if (isActive)
            {
                pnlEmployment.Enabled = true;
            }
            else
            {
                pnlEmployment.Enabled = false;

                txtCompanyName.Clear();
                rtbAddress.Clear();
                txtJobTitle.Clear();

                rbtnHired.Checked = false;
                rbtnSubmitDocs.Checked = false;
                rbtnForInterview.Checked = false;
                rbtnNotHired.Checked = false;

                dtHired.Enabled = false;
                dtSubmitDocs.Enabled = false;
                dtForInterview.Enabled = false;
                cbxRsnNotHired.Text = string.Empty;
                cbxRsnNotHired.Enabled = false;
            }
        }

        // Verification tab page
        private string Value_VerificationStatus()
        {
            if (rbtnResponded.Checked) return "Responded";
            else if (rbtnNoResponse.Checked) return "No Response";

            return string.Empty;
        }

        private string Value_TypeOfResponse()
        {
            if (rbtnInterested.Checked) return "Interested";
            else if (rbtnNotInterested.Checked) return "Not Interested";
            else return string.Empty;
        }

        private bool Value_ReferToCompany()
        {
            if (rbtnYes.Checked) return true;
            else if (rbtnNo.Checked) return false;

            return false;
        }

        private string Value_ReferralDate()
        {
            if (dtReferCompany.Enabled)
            {
                string date = $"\"{dtReferCompany.Text}\"";
                return date;
            }
            else return "null";
        }

        private string Value_FollowUpDate_1()
        {
            if (dtDateFollowup1.Enabled)
            {
                string date = $"\"{dtDateFollowup1.Text}\"";
                return date;
            }
            else return "null";
        }

        private string Value_FollowUpDate_2()
        {
            if (dtDateFollowup2.Enabled)
            {
                string date = $"\"{dtDateFollowup2.Text}\"";
                return date;
            }
            else return "null";
        }

        // Employment tab page
        private string Value_EmploymentStatus()
        {
            if (rbtnHired.Checked) return "Hired";
            else if (rbtnSubmitDocs.Checked) return "Submitted Documents";
            else if (rbtnForInterview.Checked) return "For Interview";
            else if (rbtnNotHired.Checked) return "Not Hired";
            else return string.Empty;
        }

        private string Value_HiredDate()
        {
            if (dtHired.Enabled)
            {
                string date = $"\"{dtHired.Text}\"";
                return date;
            }
            else return "null";
        }

        private string Value_SubmittedDocumentsDate()
        {
            if (dtSubmitDocs.Enabled)
            {
                string date = $"\"{dtSubmitDocs.Text}\"";
                return date;
            }
            else return "null";
        }

        private string Value_ForInterviewDate()
        {
            if (dtForInterview.Enabled)
            {
                string date = $"\"{dtForInterview.Text}\"";
                return date;
            }
            else return "null";
        }

        #endregion
    }
}
