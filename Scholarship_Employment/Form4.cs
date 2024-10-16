using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "SELECT id, last_name, first_name, middle_initial, suffix FROM scholarship_employment;";
                    command = new MySqlCommand(sql, connection);

                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        listView1.Items.Add(reader.GetInt32(0).ToString());
                        listView1.Items[i].SubItems.Add(reader.GetString(1));
                        listView1.Items[i].SubItems.Add(reader.GetString(2));
                        listView1.Items[i].SubItems.Add(reader.GetString(3));
                        listView1.Items[i].SubItems.Add(reader.GetString(4));

                        i++;
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].Text);

            FrmDetails frmDetails = new FrmDetails();
            frmDetails.Id = id;

            frmDetails.MdiParent = Form1.Instance;
            frmDetails.Show();
            //MessageBox.Show($"{listView1.SelectedItems[0].SubItems[1].Text} ");
        }
    }
}
