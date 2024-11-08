﻿using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmRecords : Form
    {
        private int _selectedID = 0;

        public FrmRecords()
        {
            InitializeComponent();
        }

        private void FrmRecords_Load(object sender, EventArgs e)
        {
            RefreshAllRecords();

            cbxSearchBy.SelectedIndex = 0;
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            ShowFrmDetails();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) return;

            ShowFrmDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) return;

            ShowFrmUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) return;

            DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        private void btnClearAllRecords_Click(object sender, EventArgs e)
        {
            string message = "The following action cannot be undone. Are you sure to clear all records here?";
            DialogResult result = MessageBox.Show(message, "Clear All Records", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ClearAllRecords();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAllRecords();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRecord();
        }

        #region Functions

        public void RefreshAllRecords()
        {
            listView.Items.Clear();
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = $"SELECT id, last_name, first_name, middle_name, extension_name, graduation_year FROM {Utilities.DbTable};";
                    command = new MySqlCommand(sql, connection);

                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        listView.Items.Add(reader.GetInt32(0).ToString());
                        listView.Items[i].SubItems.Add(reader.GetString(1));
                        listView.Items[i].SubItems.Add(reader.GetString(2));
                        listView.Items[i].SubItems.Add(reader.GetString(3));
                        listView.Items[i].SubItems.Add(reader.GetString(4));
                        listView.Items[i].SubItems.Add("");
                        listView.Items[i].SubItems.Add(reader.GetInt32(5).ToString());
                        listView.Items[i].SubItems.Add("");

                        listView.Items[i].Font = new System.Drawing.Font("Segoe UI Light", 12f);

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

        private void SearchRecord()
        {
            listView.Items.Clear();

            string input = txtSearch.Text;
            string selectedItem = cbxSearchBy.SelectedItem.ToString();

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;
                    string sql = "SELECT * FROM scholarship_employment;";

                    switch (selectedItem)
                    {
                        case "Record number":
                            int inputNum = int.Parse(input);
                            sql = $"CALL search_id(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", inputNum);
                            break;

                        case "Last name":
                            sql = $"CALL search_lastname(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case "First name":
                            sql = $"CALL search_firstname(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case "Middle name":
                            sql = $"CALL search_middleinitial(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case "Extension name":
                            sql = $"CALL search_suffix(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        default:
                            sql = "SELECT * FROM scholarship_employment;";
                            command = new MySqlCommand(sql, connection);
                            break;
                    }

                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        listView.Items.Add(reader.GetInt32(0).ToString());
                        listView.Items[i].SubItems.Add(reader.GetString(1));
                        listView.Items[i].SubItems.Add(reader.GetString(2));
                        listView.Items[i].SubItems.Add(reader.GetString(3));
                        listView.Items[i].SubItems.Add(reader.GetString(4));

                        listView.Items[i].Font = new System.Drawing.Font("Segoe UI Light", 12f);

                        i++;
                    }

                    connection.Close();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Format Exception");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        private void ShowFrmDetails()
        {
            _selectedID = int.Parse(listView.SelectedItems[0].Text);

            FrmDetails frmDetails = new FrmDetails();
            frmDetails.Id = _selectedID;

            frmDetails.ShowDialog();
        }

        private void ShowFrmUpdate()
        {
            _selectedID = int.Parse(listView.SelectedItems[0].Text);

            FrmUpdate frmUpdate = new FrmUpdate(this);
            frmUpdate.Id = _selectedID;
            frmUpdate.ShowDialog();
        }

        private void DeleteRecord()
        {
            _selectedID = int.Parse(listView.SelectedItems[0].Text);

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = $"DELETE FROM {Utilities.DbTable} WHERE id = @id";
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

        private void ClearAllRecords()
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;

                    string sql = $"TRUNCATE TABLE {Utilities.DbTable}";
                    command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    RefreshAllRecords();
                    MessageBox.Show("All records have been cleared successfully.");

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        #endregion
    }
}
