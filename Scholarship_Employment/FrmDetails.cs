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

                    string sql = $"SELECT * FROM {Utilities.DbTable} WHERE id = @id";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);
                    
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listView1.Items[0].SubItems.Add($"{reader.GetString(2)} {reader.GetString(3)} {reader.GetString(1)} {reader.GetString(4)}");
                        listView1.Items[1].SubItems.Add($"{reader.GetString(5)}");
                        listView1.Items[2].SubItems.Add($"{reader.GetDateTime(6).Date}");
                        listView1.Items[3].SubItems.Add($"{reader.GetString(7)}");
                        listView1.Items[4].SubItems.Add($"{reader.GetString(8)}");
                        listView1.Items[5].SubItems.Add($"{reader.GetString(9)}");
                        listView1.Items[6].SubItems.Add($"{reader.GetString(10)}");
                        listView1.Items[7].SubItems.Add($"{reader.GetString(11)}");
                        listView1.Items[8].SubItems.Add($"{reader.GetString(12)}");
                        listView1.Items[9].SubItems.Add($"{reader.GetInt32(13)}");
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
