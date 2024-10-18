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

            _frmUpdate = new FrmUpdate(this);
        }

        private void FrmRecords_Load(object sender, EventArgs e)
        {
            RefreshAllRecords();
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

        public void RefreshAllRecords()
        {
            listView1.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = $"SELECT id, last_name, first_name, middle_initial, suffix FROM {Utilities.DbTable};";
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

        private void ShowFrmDetails()
        {
            int id = int.Parse(listView1.SelectedItems[0].Text);

            FrmDetails frmDetails = new FrmDetails();
            frmDetails.Id = id;

            frmDetails.ShowDialog();
        }

        private void ShowFrmUpdate()
        {
            int id = int.Parse(listView1.SelectedItems[0].Text);

            if (_frmUpdate.IsDisposed)
            {
                _frmUpdate = new FrmUpdate(this);
            }

            _frmUpdate.Id = id;
            _frmUpdate.ShowDialog();
        }
    }
}
