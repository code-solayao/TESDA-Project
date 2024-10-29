using MySqlConnector;
using System;
using System.Text;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class Form2 : Form
    {
        private string _last_name;
        private string _first_name;
        private string _middle_initial;
        private string _suffix;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _last_name = txtLastname.Text;
            _first_name = txtFirstname.Text;
            _middle_initial = txtMiddleInitial.Text;
            _suffix = txtSuffix.Text;

            if (CheckEmptyFields()) return;

            if (chkMidInitFormat.Checked) MiddleInitialFormat();

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "CALL check_fullname(@last, @first, @middle, @suffix)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@last", _last_name.ToUpper());
                    command.Parameters.AddWithValue("@first", _first_name.ToUpper());
                    command.Parameters.AddWithValue("@middle", _middle_initial.ToUpper());
                    command.Parameters.AddWithValue("@suffix", _suffix.ToUpper());
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
                        Form3 form = new Form3();
                        form.SetFullname(_last_name, _first_name, _middle_initial, _suffix);

                        Close();
                        form.MdiParent = Form1.Instance;
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

        private void MiddleInitialFormat()
        {
            if (_middle_initial.Length == 2 && _middle_initial.Contains(".")) return;

            int removalLength = _middle_initial.Length - 2;
            StringBuilder builder = new StringBuilder(_middle_initial.ToUpper());
            builder.Remove(2, removalLength);

            string i = builder.ToString().Substring(1, 1);
            builder.Replace(i, ".");

            _middle_initial = builder.ToString();
        }
    }
}
