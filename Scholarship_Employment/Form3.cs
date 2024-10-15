using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class Form3 : Form
    {
        MySqlConnectionStringBuilder _conn = null;
        MySqlCommand _command = null;

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
            _conn = new MySqlConnectionStringBuilder();
            _conn.Server = "localhost";
            _conn.UserID = "root";
            _conn.Password = "Mysql.Tesda2024";
            _conn.Database = "tesda_db";

            lblFullname.Text = $"{_firstname} {_middleInitial} {_lastname} {_suffix}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to submit this information?", "Confirm Submission", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SendToDatabase();
            }
        }

        private void SendToDatabase()
        {
            dtBirthDate.Format = DateTimePickerFormat.Custom;
            dtBirthDate.CustomFormat = "yyyy-MM-dd";

            _sex = cbxSex.Text;
            _birthdate = dtBirthDate.Text;
            _address = rtxtAddress.Text;
            _qualification = txtQualification.Text;
            _tvi = txtTVI.Text;
            _district = txtDistrict.Text;
            _city = txtCity.Text;
            _scholarship_type = cbxScholarType.Text;
            _graduation_year = int.Parse(cbxGradYear.Text);

            using (MySqlConnection connection = new MySqlConnection(_conn.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "CALL submit_data(@last_name, @first_name, @middle_initial, @suffix, @sex, @birthdate, @address, @qualification, @tvi_name, @district, @city, @scholarship_type, @graduation_year)";
                    _command = new MySqlCommand(sql, connection);
                    _command.Parameters.AddWithValue("@last_name", _lastname);
                    _command.Parameters.AddWithValue("@first_name", _firstname);
                    _command.Parameters.AddWithValue("@middle_initial", _middleInitial);
                    _command.Parameters.AddWithValue("@suffix", _suffix);
                    _command.Parameters.AddWithValue("@sex", _sex);
                    _command.Parameters.AddWithValue("@birthdate", _birthdate);
                    _command.Parameters.AddWithValue("@address", _address);
                    _command.Parameters.AddWithValue("@qualification", _qualification);
                    _command.Parameters.AddWithValue("@tvi_name", _tvi);
                    _command.Parameters.AddWithValue("@district", _district);
                    _command.Parameters.AddWithValue("@city", _city);
                    _command.Parameters.AddWithValue("@scholarship_type", _scholarship_type);
                    _command.Parameters.AddWithValue("@graduation_year", _graduation_year);
                    _command.ExecuteNonQuery();

                    ClearResetAll();

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

        private void ClearResetAll()
        {
            dtBirthDate.Format = DateTimePickerFormat.Long;

            cbxSex.ResetText();
            dtBirthDate.Value = DateTime.Now;
            rtxtAddress.Clear();
            txtQualification.Clear();
            txtTVI.Clear();
            txtDistrict.Clear();
            txtCity.Clear();
            cbxScholarType.ResetText();
            cbxGradYear.ResetText();
        }
    }
}
