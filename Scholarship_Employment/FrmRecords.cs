using MySqlConnector;
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

                    string sql = $"CALL refresh_records();";
                    command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    int i = 0;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listView.Items.Add(reader.GetInt32(0).ToString());
                            listView.Items[i].SubItems.Add(reader.GetString(1));
                            listView.Items[i].SubItems.Add(reader.GetString(2));
                            listView.Items[i].SubItems.Add(reader.GetString(3));
                            listView.Items[i].SubItems.Add(reader.GetString(4));
                            listView.Items[i].SubItems.Add(reader.GetString(5));
                            listView.Items[i].SubItems.Add(reader.GetString(6));
                            listView.Items[i].SubItems.Add(reader.GetString(7));

                            listView.Items[i].Font = new System.Drawing.Font("Segoe UI Light", 12f);

                            i++;
                        }
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
            int selectedIndex = cbxSearchBy.SelectedIndex;

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = null;
                    string sql = string.Empty;
                    int inputNum;

                    switch (selectedIndex)
                    {
                        case 0:
                            // All records
                            sql = "CALL refresh_records();";
                            command = new MySqlCommand(sql, connection);
                            break;

                        case 1:
                            // Record number
                            inputNum = int.Parse(input);
                            sql = $"CALL search_id(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", inputNum);
                            break;

                        case 2:
                            // Last name
                            sql = $"CALL search_lastname(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case 3:
                            // First name
                            sql = $"CALL search_firstname(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case 4:
                            // Middle name
                            sql = $"CALL search_middlename(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case 5:
                            // Extension name
                            sql = $"CALL search_extension_name(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case 6:
                            // Status of Employment
                            sql = $"CALL search_employment_status(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case 7:
                            // Year of Graduation
                            sql = $"CALL search_graduation_year(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        case 8:
                            // Qualification Title
                            sql = $"CALL search_qualification_title(@input)";

                            command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@input", input);
                            break;

                        default:
                            sql = "CALL refresh_records();";
                            command = new MySqlCommand(sql, connection);
                            break;
                    }

                    int i = 0;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listView.Items.Add(reader.GetInt32(0).ToString());
                            listView.Items[i].SubItems.Add(reader.GetString(1));
                            listView.Items[i].SubItems.Add(reader.GetString(2));
                            listView.Items[i].SubItems.Add(reader.GetString(3));
                            listView.Items[i].SubItems.Add(reader.GetString(4));
                            listView.Items[i].SubItems.Add(reader.GetString(5));
                            listView.Items[i].SubItems.Add(reader.GetString(6));
                            listView.Items[i].SubItems.Add(reader.GetString(7));

                            listView.Items[i].Font = new System.Drawing.Font("Segoe UI Light", 12f);

                            i++;
                        }
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
            frmDetails.SetFrmRecords(this);
            frmDetails.Id = _selectedID;

            frmDetails.MdiParent = Form1.Instance;
            frmDetails.Show();
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

                    string sql = $"CALL delete_record(@Id)";
                    command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Id", _selectedID);
                    command.ExecuteNonQuery();

                    RefreshAllRecords();


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

                    string sql = $"CALL clear_all_records();";
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
