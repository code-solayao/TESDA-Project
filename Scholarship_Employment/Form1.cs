using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder _conn = null;
        MySqlCommand _command = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _conn = new MySqlConnectionStringBuilder();
            _conn.Server = "localhost";
            _conn.UserID = "root";
            _conn.Password = "Mysql.Tesda2024";
            _conn.Database = "tesda_db";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string last_name = txtLastname.Text;
            string first_name = txtFirstname.Text;
            string middle_initial = txtMiddleInitial.Text;
            string suffix = txtSuffix.Text;

            using (MySqlConnection connection = new MySqlConnection(_conn.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "CALL check_fullname(@last, @first)";
                    _command = new MySqlCommand(sql, connection);
                    _command.Parameters.AddWithValue("@last", last_name.ToUpper());
                    _command.Parameters.AddWithValue("@first", first_name.ToUpper());
                    _command.ExecuteNonQuery();

                    string readLastname = "";
                    string readFirstname = "";
                    MySqlDataReader reader = _command.ExecuteReader();
                    while (reader.Read())
                    {
                        readLastname += $"{reader.GetString(0)}";
                        readFirstname += $"{reader.GetString(1)}";
                    }

                    if (readLastname.Equals("") && readFirstname.Equals(""))
                    {
                        Form2 form = new Form2();
                        form.SetFullname(last_name, first_name, middle_initial, suffix);
                        form.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("This name already exists.", "Existing Name");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
