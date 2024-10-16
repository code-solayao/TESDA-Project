using MySqlConnector;
using System;
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
                        listBox1.Items.Add($"Full name: {reader.GetString(2)} {reader.GetString(3)} {reader.GetString(1)} {reader.GetString(4)}");
                        listBox1.Items.Add($"Sex: {reader.GetString(5)}");
                        listBox1.Items.Add($"Date of birth: {reader.GetDateTime(6)}");
                        listBox1.Items.Add($"Address: {reader.GetString(7)}");
                        listBox1.Items.Add($"Qualification: {reader.GetString(8)}");
                        listBox1.Items.Add($"Name of TVI: {reader.GetString(9)}");
                        listBox1.Items.Add($"District: {reader.GetString(10)}");
                        listBox1.Items.Add($"City: {reader.GetString(11)}");
                        listBox1.Items.Add($"Type of scholarship: {reader.GetString(12)}");
                        listBox1.Items.Add($"Year of graduation: {reader.GetInt32(13)}");
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
