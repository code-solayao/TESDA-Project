﻿using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmRecords : Form
    {
        private int _selectedID = 0;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAllRecords();
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
            _selectedID = int.Parse(listView1.SelectedItems[0].Text);

            FrmDetails frmDetails = new FrmDetails();
            frmDetails.Id = _selectedID;

            frmDetails.ShowDialog();
        }

        private void ShowFrmUpdate()
        {
            _selectedID = int.Parse(listView1.SelectedItems[0].Text);

            if (_frmUpdate.IsDisposed)
            {
                _frmUpdate = new FrmUpdate(this);
            }

            _frmUpdate.Id = _selectedID;
            _frmUpdate.ShowDialog();
        }

        private void DeleteRecord()
        {
            _selectedID = int.Parse(listView1.SelectedItems[0].Text);

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = "DELETE FROM scholarship_employment WHERE id = @id";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", _selectedID);
                    command.ExecuteNonQuery();

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
