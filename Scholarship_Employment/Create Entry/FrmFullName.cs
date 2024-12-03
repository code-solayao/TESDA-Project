using MySqlConnector;
using System;
using System.Text;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmFullName : Form
    {
        private string _last_name;
        private string _first_name;
        private string _middle_name;
        private string _extension_name;

        public FrmFullName()
        {
            InitializeComponent();

            MdiParent = Form1.Instance;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            CheckExistingName();
        }

        private void CheckExistingName()
        {
            _last_name = txtLastName.Text;
            _first_name = txtFirstName.Text;
            _middle_name = txtMiddleName.Text;
            _extension_name = cbxExtnName.Text;

            if (CheckEmptyFields()) return;

            CheckExtensionName();

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "CALL check_fullname(@last, @first, @middle, @extn)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@last", _last_name.ToUpper());
                    command.Parameters.AddWithValue("@first", _first_name.ToUpper());
                    command.Parameters.AddWithValue("@middle", _middle_name.ToUpper());
                    command.Parameters.AddWithValue("@extn", _extension_name.ToUpper());
                    command.ExecuteNonQuery();

                    string readLastname = "";
                    string readFirstname = "";
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        readLastname += $"{reader.GetString(0)}";
                        readFirstname += $"{reader.GetString(1)}";
                    }

                    if (readLastname.Equals("") && readFirstname.Equals(""))
                    {
                        FrmCreate form = new FrmCreate();
                        form.SetFullname(_last_name, _first_name, _middle_name, _extension_name);

                        Close();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("This name already exists.", "Existing Name");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        private bool CheckEmptyFields()
        {
            if (_last_name.Equals("") || _first_name.Equals(""))
            {
                if (_last_name.Equals(""))
                {
                    MessageBox.Show("Last name is required.", "Empty Field");
                }
                else if (_first_name.Equals(""))
                {
                    MessageBox.Show("First name is required.", "Empty Field");
                }

                return true;
            }

            return false;
        }

        private void CheckExtensionName()
        {
            if (cbxExtnName.Text.Equals("None")) _extension_name = string.Empty;
        }
    }
}
