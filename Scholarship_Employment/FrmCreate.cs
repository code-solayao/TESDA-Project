using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmCreate : Form
    {
        private string _last_name;
        private string _first_name;
        private string _middle_name;
        private string _extension_name;

        private string _sex;
        private string _birthdate;
        private string _contact_number;
        private string _address;
        private string _email;
        private string _sector;
        private string _qualification;
        private string _tvi;
        private string _district;
        private string _city;
        private string _scholarship_type;
        private int _graduation_year;
        private string _allocation;

        public FrmCreate()
        {
            InitializeComponent();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            txtNameDisplay.Text = $"{_first_name} {_middle_name} {_last_name} {_extension_name}";

            cbxCity.Items.Clear();
            cbxGradYear.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = "Do you wish to submit this information?";
            DialogResult result = MessageBox.Show(message, "Confirm Submission", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                InsertToDatabaseTable();
            }
        }

        private void cbxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistrictToCitySelection();
        }

        #region Functions

        private void InsertToDatabaseTable()
        {
            if (!ContactNumberFormat()) return;

            dtBirthDate.Format = DateTimePickerFormat.Custom;
            dtBirthDate.CustomFormat = "MM/dd/yyyy";

            _sex = cbxSex.Text;
            _birthdate = dtBirthDate.Text;
            _contact_number = txtContactNum.Text;
            _address = rtxtAddress.Text;
            _email = txtEmail.Text;
            _sector = cbxSector.Text;
            _qualification = txtQualification.Text;
            _tvi = txtTVI.Text;
            _district = cbxDistrict.Text;
            _city = cbxCity.Text;
            _scholarship_type = cbxScholarType.Text;
            _graduation_year = int.Parse(cbxGradYear.Text);
            _allocation = "FY " + _graduation_year;

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "CALL submit_record_data(@district, @city, @tvi, @qualification_title, @sector, @last_name, @first_name, " +
                        "@middle_name, @extension_name, @full_name, @sex, @birthdate, @contact_number, @email, @scholarship_type, " +
                        "@address, @allocation)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@district", _district);
                    command.Parameters.AddWithValue("@city", _city);
                    command.Parameters.AddWithValue("@tvi", _tvi);
                    command.Parameters.AddWithValue("@qualification_title", _qualification);
                    command.Parameters.AddWithValue("@sector", _sector);
                    command.Parameters.AddWithValue("@last_name", _last_name);
                    command.Parameters.AddWithValue("@first_name", _first_name);
                    command.Parameters.AddWithValue("@middle_name", _middle_name);
                    command.Parameters.AddWithValue("@extension_name", _extension_name);
                    command.Parameters.AddWithValue("@full_name", FullNameFormat());
                    command.Parameters.AddWithValue("@sex", _sex);
                    command.Parameters.AddWithValue("@birthdate", _birthdate);
                    command.Parameters.AddWithValue("@contact_number", _contact_number);
                    command.Parameters.AddWithValue("@email", _email);
                    command.Parameters.AddWithValue("@scholarship_type", _scholarship_type);
                    command.Parameters.AddWithValue("@address", _address);
                    command.Parameters.AddWithValue("@allocation", _allocation);
                    command.ExecuteNonQuery();

                    dtBirthDate.Format = DateTimePickerFormat.Long;

                    sql = "CALL get_new_record_id(@last_name, @first_name)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@last_name", _last_name);
                    command.Parameters.AddWithValue("@first_name", _first_name);
                    command.ExecuteNonQuery();

                    int id = 0;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }

                    sql = "CALL initialise_verification_record(@Id)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();

                    sql = "CALL initialise_employment_record(@Id)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();

                    Close();
                    FrmRecords form = new FrmRecords();
                    form.MdiParent = Form1.Instance;
                    form.Show();

                    MessageBox.Show("The information was submitted successfully.");

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        public void SetFullname(string lastname, string firstname, string middleInitial, string suffix)
        {
            _last_name = lastname;
            _first_name = firstname;
            _middle_name = middleInitial;
            _extension_name = suffix;
        }

        private string FullNameFormat()
        {
            string full_name = string.Empty;

            if (_extension_name.Equals(string.Empty) && _middle_name.Equals(string.Empty))
            {
                full_name = $"{_last_name}, {_first_name}";
            }
            else if (_extension_name.Equals(string.Empty))
            {
                full_name = $"{_last_name}, {_first_name} {_middle_name}";
            }
            else if (_middle_name.Equals(string.Empty))
            {
                full_name = $"{_last_name} {_extension_name}, {_first_name}";
            }
            else
                full_name = $"{_last_name} {_extension_name}, {_first_name} {_middle_name}";

            return full_name;
        }

        private bool ContactNumberFormat()
        {
            if (txtContactNum.Text.Length < 11)
            {
                MessageBox.Show("Contact number must have 11 digits.", "ERROR: Contact Number");
                return false;
            }

            try
            {
                long contactNum = long.Parse(txtContactNum.Text);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void DistrictToCitySelection()
        {
            try
            {
                cbxCity.Text = string.Empty;
                cbxCity.Items.Clear();

                string selectedItem = cbxDistrict.SelectedItem.ToString();
                switch (selectedItem)
                {
                    case "CaMaNaVa":
                        cbxCity.Items.Add("Caloocan City");
                        cbxCity.Items.Add("Malabon City");
                        cbxCity.Items.Add("Navotas City");
                        cbxCity.Items.Add("Valenzuela City");
                        break;

                    case "Manila":
                        cbxCity.Items.Add("Manila");

                        cbxCity.Text = "Manila";
                        break;

                    case "MuntiParLasTaPat":
                        cbxCity.Items.Add("Las Piñas City");
                        cbxCity.Items.Add("Muntinlupa City");
                        cbxCity.Items.Add("Parañaque City");
                        cbxCity.Items.Add("Taguig City");
                        break;

                    case "PaMaMariSan":
                        cbxCity.Items.Add("Mandaluyong City");
                        cbxCity.Items.Add("Marikina City");
                        cbxCity.Items.Add("Pasig City");
                        cbxCity.Items.Add("San Juan City");
                        break;

                    case "Pasay-Makati":
                        cbxCity.Items.Add("Makati City");
                        cbxCity.Items.Add("Pasig City");
                        break;

                    case "Quezon City":
                        cbxCity.Items.Add("Quezon City");

                        cbxCity.Text = "Quezon City";
                        break;

                    default:
                        cbxCity.Items.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        #endregion
    }
}
