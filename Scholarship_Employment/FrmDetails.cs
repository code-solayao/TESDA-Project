using MySqlConnector;
using System;
using System.Collections.Generic;
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
            LoadDetails();
        }

        private void LoadDetails()
        {
            InitialiseClearDetails();

            string last_name, first_name, middle_name, extension_name;
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "CALL retrieve_initial_record(@id)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            last_name = reader.GetString(0);
                            first_name = reader.GetString(1);
                            middle_name = reader.GetString(2);
                            extension_name = reader.GetString(3);
                            lblFullName.Text = FullNameFormat();

                            lblSex.Text = reader.GetString(4);
                            lblBirthDate.Text = DateOfBirthFormat(reader.GetDateTime(5));
                            lblContactNum.Text = reader.GetString(6);
                            lblAddress.Text = reader.GetString(7);
                            lblEmail.Text = reader.GetString(8);
                            lblSector.Text = reader.GetString(9);
                            lblQualiTitle.Text = reader.GetString(10);
                            lblTVI.Text = reader.GetString(11);
                            lblDistrict.Text = reader.GetString(12);
                            lblCity.Text = reader.GetString(13);
                            lblScholarType.Text = reader.GetString(14);
                            lblGradYear.Text = reader.GetInt32(15).ToString();
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }

            string FullNameFormat()
            {
                string full_name = string.Empty;

                if (extension_name.Equals(string.Empty) && middle_name.Equals(string.Empty))
                {
                    full_name = $"{last_name}, {first_name}";
                }
                else if (extension_name.Equals(string.Empty))
                {
                    full_name = $"{last_name}, {first_name} {middle_name}";
                }
                else if (middle_name.Equals(string.Empty))
                {
                    full_name = $"{last_name} {extension_name}, {first_name}";
                }
                else 
                    full_name = $"{last_name} {extension_name}, {first_name} {middle_name}";

                return full_name;
            }

            string DateOfBirthFormat(DateTime readerDateTime)
            {
                string monthName = string.Empty;
                int month = readerDateTime.Month;
                switch (month)
                {
                    case 1:
                        monthName = "January";
                        break;

                    case 2:
                        monthName = "February";
                        break;

                    case 3:
                        monthName = "March";
                        break;

                    case 4:
                        monthName = "April";
                        break;

                    case 5:
                        monthName = "May";
                        break;

                    case 6:
                        monthName = "June";
                        break;

                    case 7:
                        monthName = "July";
                        break;

                    case 8:
                        monthName = "August";
                        break;

                    case 9:
                        monthName = "September";
                        break;

                    case 10:
                        monthName = "October";
                        break;

                    case 11:
                        monthName = "November";
                        break;

                    case 12:
                        monthName = "December";
                        break;

                    default:
                        monthName = "";
                        break;
                }

                string format = $"{monthName} {readerDateTime.Day}, {readerDateTime.Year}";
                return format;
            }
        }

        private void InitialiseClearDetails()
        {
            List<Label> _detailsLabels = new List<Label>
            {
                lblFullName,
                lblSex,
                lblBirthDate,
                lblContactNum,
                lblAddress,
                lblEmail,
                lblSector,
                lblQualiTitle,
                lblDistrict,
                lblCity,
                lblScholarType,
                lblTVI,
                lblGradYear
            };

            foreach (Label detail in _detailsLabels)
            {
                detail.Text = string.Empty;
            }
        }

        void LumangDetalye()
        {
            /*
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
            */
        }
    }
}
