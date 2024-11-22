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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                MessageBox.Show("no row index");
                return;
            }

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            DataGridViewCellCollection cellCollection = row.Cells;
            System.Collections.Generic.List<DataGridViewCell> cells = new System.Collections.Generic.List<DataGridViewCell>();
            foreach (DataGridViewCell cell in cellCollection)
            {
                cells.Add(cell);
            }
        }
    }
}
