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
        private bool _referral_status;
        private string _company_name;
        private string _responded_reason;
        private string _follow_up_date;
        private string _not_interested_reason;

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
                dtDateFollowup,
                dtDateHired
            };

            InitialiseClearDetails();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            LoadDetails();
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

        private void cbxStatusVerify_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbxStatusVerify.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Responded":
                    grpResponded.Visible = true;
                    grpNoResponse.Visible = false;
                    break;

                case "No Response (For Follow-up)":
                    grpNoResponse.Visible = true;
                    grpResponded.Visible = false;
                    break;

                default:
                    grpResponded.Visible = false;
                    grpNoResponse.Visible = false;
                    break;
            }
        }

        private void rbtnInterested_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInterested.Checked)
            {
                grpReferralStatus.Enabled = true;
                rtbRsnNotInterested.Enabled = false;
            }
        }

        private void rbtnNotInterested_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNotInterested.Checked)
            {
                rtbRsnNotInterested.Enabled = true;
                grpReferralStatus.Enabled = false;
            }
        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)
            {
                rtbRsnRefStatusNo.Enabled = false;

                // Redirect to Employment tab page
            }
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNo.Checked)
            {
                rtbRsnRefStatusNo.Enabled = true;
            }
        }

        private void rbtnHired_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHired.Checked) dtDateHired.Enabled = true;
            else dtDateHired.Enabled = false;
        }

        private void rbtnNotHired_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNotHired.Checked) cbxReason.Enabled = true;
            else cbxReason.Enabled = false;
        }

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
                    MessageBox.Show(ex.Message);
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

            _verification_means = cbxMeansVerify.Text;
            _verification_date = dtDateVerify.Text;
            _verification_status = cbxStatusVerify.Text;
            _referral_status = ReferralStatusValue();
            //_company_name = txtCompanyName.Text;
            _responded_reason = rtbRsnNotInterested.Text;
            _follow_up_date = dtDateFollowup.Text;
            // _not_interested_reason = rtbRsnNotInterested.Text;

            MessageBox.Show(_follow_up_date);

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "CALL update_record(@id, @means, @date, @status, @refstatus, @company_name, @responded_rsn, " +
                        "@followup_date, @not_interested_rsn);";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@means", _verification_means);
                    command.Parameters.AddWithValue("@date", _verification_date);
                    command.Parameters.AddWithValue("@status", _verification_status);
                    command.Parameters.AddWithValue("@refstatus", _referral_status);
                    command.Parameters.AddWithValue("@company_name", _company_name);
                    command.Parameters.AddWithValue("@responded_rsn", _responded_reason);
                    command.Parameters.AddWithValue("@followup_date", _follow_up_date);
                    command.Parameters.AddWithValue("@not_interested_rsn", _not_interested_reason);
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

        private bool ReferralStatusValue()
        {
            if (rbtnYes.Checked) return true;
            else if (rbtnNo.Checked) return false;

            return false;
        }

        private bool CheckIfNoChanges
        {
            get
            {
                int x = 0;

                return x == 13;
            }
        }

        #endregion
    }
}
