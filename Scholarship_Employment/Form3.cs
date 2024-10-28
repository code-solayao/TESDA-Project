using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class Form3 : Form
    {
        private string _lastname;
        private string _firstname;
        private string _middleInitial;
        private string _suffix;

        private string _sex;
        private string _birthdate;
        private string _address;
        private string _qualification;
        private string _tvi;
        private string _district;
        private string _city;
        private string _scholarship_type;
        private int _graduation_year;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblFullname.Text = $"{_firstname} {_middleInitial} {_lastname} {_suffix}";
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
            dtBirthDate.Format = DateTimePickerFormat.Custom;
            dtBirthDate.CustomFormat = "yyyy-MM-dd";

            _sex = cbxSex.Text;
            _birthdate = dtBirthDate.Text;
            _address = rtxtAddress.Text;
            _qualification = txtQualification.Text;
            _tvi = txtTVI.Text;
            _district = cbxDistrict.Text;
            _city = cbxCity.Text;
            _scholarship_type = cbxScholarType.Text;
            _graduation_year = int.Parse(cbxGradYear.Text);

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "CALL submit_data(@last_name, @first_name, @middle_initial, @suffix, @sex, @birthdate, @address, @qualification, @tvi_name, @district, @city, @scholarship_type, @graduation_year)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@last_name", _lastname);
                    command.Parameters.AddWithValue("@first_name", _firstname);
                    command.Parameters.AddWithValue("@middle_initial", _middleInitial);
                    command.Parameters.AddWithValue("@suffix", _suffix);
                    command.Parameters.AddWithValue("@sex", _sex);
                    command.Parameters.AddWithValue("@birthdate", _birthdate);
                    command.Parameters.AddWithValue("@address", _address);
                    command.Parameters.AddWithValue("@qualification", _qualification);
                    command.Parameters.AddWithValue("@tvi_name", _tvi);
                    command.Parameters.AddWithValue("@district", _district);
                    command.Parameters.AddWithValue("@city", _city);
                    command.Parameters.AddWithValue("@scholarship_type", _scholarship_type);
                    command.Parameters.AddWithValue("@graduation_year", _graduation_year);
                    command.ExecuteNonQuery();

                    dtBirthDate.Format = DateTimePickerFormat.Long;

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
            _lastname = lastname;
            _firstname = firstname;
            _middleInitial = middleInitial;
            _suffix = suffix;
        }

        private void DistrictToCitySelection()
        {
            cbxCity.Items.Clear();

            string selectedItem = cbxDistrict.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "CMNV":
                    cbxCity.Items.Add("Caloocan City");
                    cbxCity.Items.Add("Malabon City");
                    cbxCity.Items.Add("Navotas City");
                    cbxCity.Items.Add("Valenzuela City");
                    break;

                case "MLA":
                    cbxCity.Items.Add("Manila");
                    break;

                case "MPLTP":
                    cbxCity.Items.Add("Las Piñas City");
                    cbxCity.Items.Add("Muntinlupa City");
                    cbxCity.Items.Add("Parañaque City");
                    cbxCity.Items.Add("Taguig City");
                    break;

                case "PMMS":
                    cbxCity.Items.Add("Mandaluyong City");
                    cbxCity.Items.Add("Marikina City");
                    cbxCity.Items.Add("Pasig City");
                    cbxCity.Items.Add("San Juan City");
                    break;

                case "PASMAK":
                    cbxCity.Items.Add("Makati City");
                    cbxCity.Items.Add("Pasig City");
                    break;

                case "QC":
                    cbxCity.Items.Add("Quezon City");
                    break;

                default:
                    cbxCity.Items.Clear();
                    break;
            }
        }

        #endregion

    }
}
