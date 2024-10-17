using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmUpdate : Form
    {
        public int Id { get; set; }

        private string _lastname;
        private string _firstname;
        private string _middleInitial;
        private string _suffix;
        private string _sex;
        private DateTime _dtBirthdate;
        private string _address;
        private string _qualification;
        private string _tvi;
        private string _district;
        private string _city;
        private string _scholarship_type;
        private int _graduation_year;

        public event EventHandler OnRecordUpdate;

        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "SELECT * FROM scholarship_employment WHERE id = @id";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtLastname.Text = reader.GetString(1);
                        txtFirstname.Text = reader.GetString(2);
                        txtMiddleInitial.Text = reader.GetString(3);
                        txtSuffix.Text = reader.GetString(4);
                        cbxSex.Text = reader.GetString(5);
                        dtBirthDate.Value = reader.GetDateTime(6).Date;
                        rtxtAddress.Text = reader.GetString(7);
                        txtQualification.Text = reader.GetString(8);
                        txtTVI.Text = reader.GetString(9);
                        txtDistrict.Text = reader.GetString(10);
                        txtCity.Text = reader.GetString(11);
                        cbxScholarType.Text = reader.GetString(12);
                        cbxGradYear.Text = reader.GetInt32(13).ToString();
                    }

                    _lastname = txtLastname.Text;
                    _firstname = txtFirstname.Text;
                    _middleInitial = txtMiddleInitial.Text;
                    _suffix = txtSuffix.Text;
                    _sex = cbxSex.Text;
                    _dtBirthdate = dtBirthDate.Value;
                    _address = rtxtAddress.Text;
                    _qualification = txtQualification.Text;
                    _tvi = txtTVI.Text;
                    _district = txtDistrict.Text;
                    _city = txtCity.Text;
                    _scholarship_type = cbxScholarType.Text;
                    _graduation_year = int.Parse(cbxGradYear.Text);

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckIfNoChanges)
            {
                Hide();
                return;
            }

            dtBirthDate.Format = DateTimePickerFormat.Custom;
            dtBirthDate.CustomFormat = "yyyy-MM-dd";
            _lastname = txtLastname.Text;
            _firstname = txtFirstname.Text;
            _middleInitial = txtMiddleInitial.Text;
            _suffix = txtSuffix.Text;
            _sex = cbxSex.Text;
            string _birthdate = dtBirthDate.Text;
            _address = rtxtAddress.Text;
            _qualification = txtQualification.Text;
            _tvi = txtTVI.Text;
            _district = txtDistrict.Text;
            _city = txtCity.Text;
            _scholarship_type = cbxScholarType.Text;
            _graduation_year = int.Parse(cbxGradYear.Text);

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "CALL update_data(@id, @last_name, @first_name, @middle_initial, @suffix, @sex, @birthdate, @address, @qualification, @tvi_name, @district, @city, @scholarship_type, @graduation_year)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);
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
                    MessageBox.Show("The information was updated successfully.");

                    OnRecordUpdate?.Invoke(this, EventArgs.Empty);
                    Hide();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool CheckIfNoChanges
        {
            get
            {
                int x = 0;
                if (txtLastname.Text.Equals(_lastname)) x++;
                if (txtFirstname.Text.Equals(_firstname)) x++;
                if (txtMiddleInitial.Text.Equals(_middleInitial)) x++;
                if (txtSuffix.Text.Equals(_suffix)) x++;
                if (cbxSex.Text.Equals(_sex)) x++;
                if (dtBirthDate.Value.Equals(_dtBirthdate)) x++;
                if (rtxtAddress.Text.Equals(_address)) x++;
                if (txtQualification.Text.Equals(_qualification)) x++;
                if (txtTVI.Text.Equals(_tvi)) x++;
                if (txtDistrict.Text.Equals(_district)) x++;
                if (txtCity.Text.Equals(_city)) x++;
                if (cbxScholarType.Text.Equals(_scholarship_type)) x++;
                if (cbxGradYear.Text.Equals(_graduation_year.ToString())) x++;

                return x == 13;
            }
        }
    }
}
