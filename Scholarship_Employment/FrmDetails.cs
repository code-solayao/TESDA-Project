using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmDetails : Form
    {
        public int Id { private get; set; }

        private FrmRecords _frmRecords;

        private bool _enableEmploymentPage = false;

        public FrmDetails()
        {
            InitializeComponent();
        }

        private void FrmDetails_Load(object sender, EventArgs e)
        {
            RefreshFrmDetails();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            FrmUpdate frmUpdate = new FrmUpdate();
            frmUpdate.RefreshForms(_frmRecords, this);
            frmUpdate.Id = Id;

            frmUpdate.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_frmRecords != null) _frmRecords.RefreshAllRecords();
            Close();
        }

        #region Functions

        public void SetFrmRecords(FrmRecords frmRecords) => _frmRecords = frmRecords;

        public void RefreshFrmDetails()
        {
            InitialiseClearAll();

            LoadDetails();
            LoadVerificationRecord();
            LoadEmploymentRecord();
        }

        private void InitialiseClearAll()
        {
            List<Label> _detailsLabels = new List<Label>
            {
                lblFullName,
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
            string last_name, first_name, middle_name, extension_name;
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "CALL retrieve_initial_record(@id)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            last_name = reader.GetString(0);
                            first_name = reader.GetString(1);
                            middle_name = reader.GetString(2);
                            extension_name = reader.GetString(3);
                            lblFullName.Text = FullNameFormat();

                            lblSex.Text = reader.GetString(4);
                            lblBirthDate.Text = DateFormatRead(reader, 5);
                            lblContactNum.Text = reader.GetString(6);
                            lblAddress.Text = reader.GetString(7);
                            lblEmail.Text = reader.GetString(8);
                            lblSector.Text = reader.GetString(9);
                            lblQualiTitle.Text = reader.GetString(10);
                            lblTVI.Text = reader.GetString(11);
                            lblDistrict.Text = reader.GetString(12);
                            lblCity.Text = reader.GetString(13);
                            lblScholarType.Text = reader.GetString(14);
                            lblGradYear.Text = reader.GetInt32(15).ToString();
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }

            string FullNameFormat()
            {
                string full_name = string.Empty;

                if (extension_name.Equals(string.Empty) && middle_name.Equals(string.Empty))
                {
                    full_name = $"{last_name}, {first_name}";
                }
                else if (extension_name.Equals(string.Empty))
                {
                    full_name = $"{last_name}, {first_name} {middle_name}";
                }
                else if (middle_name.Equals(string.Empty))
                {
                    full_name = $"{last_name} {extension_name}, {first_name}";
                }
                else 
                    full_name = $"{last_name} {extension_name}, {first_name} {middle_name}";

                return full_name;
            }
        }

        private void LoadVerificationRecord()
        {
            string means_of_verification;
            string date_of_verification;
            string status_of_verifcation;

            string type_of_response;
            string refer_to_company;
            string date_of_referral;
            string reason_no_referral;
            string reason_not_interested;

            string follow_up_date_1;
            string follow_up_date_2;
            bool invalid_contact = false;

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "CALL retrieve_verification_record(@id);";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            means_of_verification = reader.GetString(0);
                            date_of_verification = DateFormatRead(reader, 1);
                            status_of_verifcation = reader.GetString(2);
                            type_of_response = reader.GetString(3);

                            refer_to_company = ReferToCompanyValue(reader.GetInt16(4));
                            date_of_referral = DateFormatRead(reader, 5);
                            reason_no_referral = reader.GetString(6);
                            reason_not_interested = reader.GetString(7);

                            follow_up_date_1 = DateFormatRead(reader, 8);
                            follow_up_date_2 = DateFormatRead(reader, 9);
                            invalid_contact = reader.GetBoolean(10);

                            lblVerifyMeans.Text = means_of_verification;
                            lblVerifyDate.Text = date_of_verification;
                            StatusOfVerificationAction();
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }

            void StatusOfVerificationAction()
            {
                lblVerifyStatus.Text = status_of_verifcation;
                pnlNoResponse.Location = pnlResponded.Location;

                switch (status_of_verifcation)
                {
                    case "Responded":
                        pnlResponded.Visible = true;
                        pnlNoResponse.Visible = false;

                        TypeOfResponseAction();
                        ReferToCompanyAction();
                        break;

                    case "No Response":
                        pnlNoResponse.Visible = true;
                        pnlResponded.Visible = false;

                        lblFollowup1.Text = follow_up_date_1;
                        lblFollowup2.Text = follow_up_date_2;
                        chkInvalidContact.Checked = invalid_contact;
                        break;

                    default:
                        pnlResponded.Visible = false;
                        pnlNoResponse.Visible = false;
                        break;
                }
            }

            string ReferToCompanyValue(short reader)
            {
                string response = string.Empty;
                switch (reader)
                {
                    case 0:
                        response = "No response";
                        break;

                    case 1:
                        response = "Yes";
                        break;

                    case 2:
                        response = "No";
                        break;

                    default:
                        response = "No response";
                        break;
                }

                return response;
            }

            void TypeOfResponseAction()
            {
                lblResponseType.Text = type_of_response;

                switch (type_of_response)
                {
                    case "Interested":
                        ver_label_1.Text = "Refer to Company? ";
                        ver_label_1.Location = new Point(25, 50);

                        ver_label_2.Visible = true;
                        ver_value_2.Visible = true;

                        ver_value_1.Text = refer_to_company;
                        break;

                    case "Not Interested":
                        ver_label_1.Text = "Reason: ";
                        ver_label_1.Location = new Point(135, 50);

                        ver_label_2.Visible = false;
                        ver_value_2.Visible = false;

                        ver_value_1.Text = reason_not_interested;
                        break;

                    default:
                        ver_label_1.Visible = false;
                        ver_value_1.Visible = false;

                        ver_label_2.Visible = false;
                        ver_value_2.Visible = false;
                        break;
                }
            }

            void ReferToCompanyAction()
            {
                switch (refer_to_company)
                {
                    case "Yes":
                        ver_label_2.Text = "Date of Referral: ";
                        ver_label_2.Location = new Point(51, 90);

                        ver_value_2.Text = date_of_referral;
                        _enableEmploymentPage = true;
                        break;

                    case "No":
                        ver_label_2.Text = "Reason: ";
                        ver_label_2.Location = new Point(135, 90);

                        ver_value_2.Text = reason_no_referral;
                        _enableEmploymentPage = false;
                        break;

                    default:
                        ver_label_2.Visible = false;
                        ver_value_2.Visible = false;
                        _enableEmploymentPage = false;
                        break;
                }
            }
        }

        private void LoadEmploymentRecord()
        {
            if (!_enableEmploymentPage) 
                pnlEmployment.Enabled = false;
            else 
                pnlEmployment.Enabled = true;

            string company_name;
            string company_address;
            string job_title;

            string employment_status;
            string hired_date;
            string submitted_documents_date;
            string for_interview_date;
            string reason_not_hired;

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "CALL retrieve_employment_record(@id)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            company_name = reader.GetString(0);
                            company_address = reader.GetString(1);
                            job_title = reader.GetString(2);

                            employment_status = reader.GetString(3);
                            hired_date = DateFormatRead(reader, 4);
                            submitted_documents_date = DateFormatRead(reader, 5);
                            for_interview_date = DateFormatRead(reader, 6);
                            reason_not_hired = reader.GetString(7);

                            lblCompanyName.Text = company_name;
                            lblCompanyAddress.Text = company_address;
                            lblJobTitle.Text = job_title;
                            EmploymentStatusAction();
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }

            void EmploymentStatusAction()
            {
                lblEmpStatus.Text = employment_status;

                emp_label.Visible = true;
                emp_value.Visible = true;

                switch (employment_status)
                {
                    case "Hired":
                        emp_label.Text = "Date Hired: ";
                        emp_label.Location = new Point(115, 240);

                        emp_value.Text = hired_date;
                        break;

                    case "Submitted Documents":
                        emp_label.Text = "Date of Submission: ";
                        emp_label.Location = new Point(29, 240);

                        emp_value.Text = submitted_documents_date;
                        break;

                    case "For Interview":
                        emp_label.Text = "Interview Date: ";
                        emp_label.Location = new Point(76, 240);

                        emp_value.Text = for_interview_date;
                        break;

                    case "Not Hired":
                        emp_label.Text = "Reason: ";
                        emp_label.Location = new Point(150, 240);

                        emp_value.Text = reason_not_hired;
                        break;

                    default:
                        emp_label.Visible = false;
                        emp_value.Visible = false;
                        break;
                }
            }
        }

        private string DateFormatRead(MySqlDataReader reader, int ordinal)
        {
            DateTime date;

            if (reader.IsDBNull(ordinal))
            {
                date = DateTime.MinValue;
                return "<no-given-date>";
            }
            else date = reader.GetDateTime(ordinal);

            string monthName = string.Empty;
            int month = date.Month;
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

            string format = $"{monthName} {date.Day}, {date.Year}";
            return format;
        }

        private void CopyFullName(object sender, EventArgs e)
        {
            Clipboard.SetText(lblFullName.Text);
        }

        #endregion
    }
}
