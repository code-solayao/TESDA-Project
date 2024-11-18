using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmDetails : Form
    {
        public int Id { get; set; }

        public FrmDetails()
        {
            InitializeComponent();
        }

        private void FrmDetails_Load(object sender, EventArgs e)
        {
            InitialiseClearAll();

            LoadDetails();
            LoadVerificationRecord();
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
                            lblBirthDate.Text = DateFormatRead(reader.GetDateTime(5));
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
                            lblVerifyMeans.Text = reader.GetString(0);
                            lblVerifyDate.Text = DateFormatRead(reader.GetDateTime(1));
                            lblVerifyStatus.Text = reader.GetString(2);
                            lblResponseType.Text = reader.GetString(3);

                            lblReferToCompany.Text = Value_ReferToCompany(reader.GetInt16(4));
                            Value_ReferYesNo(reader.GetDateTime(5), reader.GetString(6));
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }

            string Value_ReferToCompany(short reader)
            {
                string response = string.Empty;
                switch (reader)
                {
                    case 0:
                        response = "No response";
                        break;

                    case 1:
                        response = "Yes";

                        labelReferYesNo.Text = "Date of Referral: ";
                        labelReferYesNo.Location = new System.Drawing.Point(75, 40);
                        break;

                    case 2:
                        response = "No";

                        labelReferYesNo.Text = "Reason: ";
                        labelReferYesNo.Location = new System.Drawing.Point(140, 40);
                        break;

                    default:
                        response = "No response";
                        break;
                }

                return response;
            }

            string Value_ReferYesNo(DateTime referral, string reason)
            {
                string value = string.Empty;
                if (referral != null)
                {
                    return DateFormatRead(referral);
                }
                else if (!reason.Equals(string.Empty))
                {
                    return "";
                }
                else return value;
            }
        }

        private string DateFormatRead(DateTime readerDateTime)
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

        private void CopyFullName(object sender, EventArgs e)
        {
            Clipboard.SetText(lblFullName.Text);
        }
    }
}
