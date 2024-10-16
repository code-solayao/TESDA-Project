using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string last_name = txtLastname.Text;
            string first_name = txtFirstname.Text;
            string middle_initial = txtMiddleInitial.Text;
            string suffix = txtSuffix.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "CALL check_fullname(@last, @first, @middle, @suffix)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@last", last_name.ToUpper());
                    command.Parameters.AddWithValue("@first", first_name.ToUpper());
                    command.Parameters.AddWithValue("@middle", middle_initial.ToUpper());
                    command.Parameters.AddWithValue("@suffix", suffix.ToUpper());
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
                        form.SetFullname(last_name, first_name, middle_initial, suffix);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
    }
}
