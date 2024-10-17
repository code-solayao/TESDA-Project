using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmRecords : Form
    {
        private FrmUpdate _frmUpdate;

        public FrmRecords()
        {
            InitializeComponent();

            _frmUpdate = new FrmUpdate();
            _frmUpdate.OnRecordUpdate += FrmRecords_Load; // need a way to unsubscribe before closing this form
        }

        private void FrmRecords_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();

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
            ShowFrmDetails();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ShowFrmDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ShowFrmUpdate();
        }

        private void ShowFrmDetails()
        {
            int id = int.Parse(listView1.SelectedItems[0].Text);

            FrmDetails frmDetails = new FrmDetails(id);

            frmDetails.MdiParent = Form1.Instance;
            frmDetails.Show();
        }

        private void ShowFrmUpdate()
        {
            int id = int.Parse(listView1.SelectedItems[0].Text);
            _frmUpdate.Id = id;

            _frmUpdate.MdiParent = Form1.Instance;
            _frmUpdate.Show();
        }
    }
}
