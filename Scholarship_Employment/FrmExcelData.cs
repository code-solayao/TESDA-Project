using MySqlConnector;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmExcelData : Form
    {
        public FrmExcelData()
        {
            InitializeComponent();
        }

        private void FrmExcelData_Load(object sender, EventArgs e)
        {
            listView.Items.Clear();
        }

        private void btnLoadExcelData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                lblFilePath.Text = filePath;
                LoadExcelData(filePath, "yes");
            }

            //CreateDataTable();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitToDatabase();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            int rows = dataGridView.RowCount;
            int columns = dataGridView.ColumnCount;
            string cell = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                var rowValue = dataGridView.Rows[i].Cells[0].Value;
                if (rowValue == null) break;

                cell = rowValue.ToString();
                listView.Items.Add(cell);

                for (int j = 1; j < columns; j++)
                {
                    var colValue = dataGridView.Rows[i].Cells[j].Value;
                    cell = colValue.ToString();

                    listView.Items[i].SubItems.Add(cell);
                }

                listView.Items[i].Font = new System.Drawing.Font("Segoe UI Light", 12f);
            }
        }

        private void LoadExcelData(string filePath, string hdr)
        {
            string connectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            connectionString = String.Format(connectionString, filePath, hdr);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DataTable dataTableExcel = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string sheetName = dataTableExcel.Rows[0]["TABLE_NAME"].ToString();

                    string sql = $"SELECT * FROM [{sheetName}]";
                    OleDbCommand command = new OleDbCommand(sql, connection);
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }

        }

        // TEST environment
        private void CreateDataTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Birth date", typeof(DateTime));
            table.Columns.Add("Age", typeof(int));
            
            table.Rows.Add(1, "Dave Solayao", new DateTime(2001, 7, 3), 23);
            table.Rows.Add(2, "Dave Solayao", new DateTime(2001, 7, 3), 23);
            table.Rows.Add(3, "Dave Solayao", new DateTime(2001, 7, 3), 23);
            table.Rows.Add(4, "Dave Solayao", new DateTime(2001, 7, 3), 23);
            table.Rows.Add(5, "Dave Solayao", new DateTime(2001, 7, 3), 23);

            dataGridView.DataSource = table;
        }

        private void SubmitToDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "insert into test values (@ID, @Name, @Birth_Date, @Age);";
                    MySqlCommand command = null;

                    int ID;
                    string Name;
                    DateTime BirthDate;
                    int Age;
                    for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    {
                        ID = Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value);
                        Name = dataGridView.Rows[i].Cells[1].Value.ToString();
                        BirthDate = Convert.ToDateTime(dataGridView.Rows[i].Cells[2].Value);
                        Age = Convert.ToInt32(dataGridView.Rows[i].Cells[3].Value);

                        command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Birth_Date", BirthDate);
                        command.Parameters.AddWithValue("@Age", Age);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }
    }
}
