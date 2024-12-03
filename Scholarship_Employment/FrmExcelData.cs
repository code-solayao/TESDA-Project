using MySqlConnector;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmExcelData : Form
    {
        #region EmpDashboard field variables

        private string _district;
        private string _city;
        private string _tvi;
        private string _qualification;
        private string _sector;
        private string _last_name;
        private string _first_name;
        private string _middle_name;
        private string _extension_name;
        private string _full_name;
        private string _scholarship_type;
        private string _training_status;
        private string _assessment_result;
        private string _emp_before_training;
        private string _occupation;
        private string _employer;
        private string _emp_type;
        private int _allocation;
        private string _verif_status;
        private string _verif_date;
        private string _referral_status;
        private string _company;
        private string _address;
        private string _job_title;
        private string _emp_date;
        private string _emp_status;
        private string _response_type;
        private string _follow_up;
        private string _answered;
        private string _reason_not_applying;

        #endregion

        public FrmExcelData()
        {
            InitializeComponent();

            MdiParent = Form1.Instance;
        }

        private void FrmExcelData_Load(object sender, EventArgs e)
        {
            
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

        private void btnExport_Click(object sender, EventArgs e)
        {


            /*int rows = dataGridView.RowCount;
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
            }*/
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
                    dgvImport.DataSource = dataTable;
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

            dgvImport.DataSource = table;
        }

        private void SubmitToDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = $"CALL Insert_Data(@District, @City, @TVI, @Qualification, @Sector, @Last_Name, @First_Name, @Middle_Name, " +
                        $"@Extension_Name, @Full_Name, @Scholarship_Type, @Training_Status, @Assessment_Result, @Emp_Before_Training, @Occupation, " +
                        $"@Employer, @Emp_Type, @Allocation, @Verif_Status, @Verif_Date, @Referral_Status, @Company, @Address, @Job_Title, @Emp_Date, " +
                        $"@Emp_Status, @Response_Type, @Follow_Up, @Answered, @Reason_Not_Applying);";

                    MySqlCommand command = null;
                    for (int i = 0; i < dgvImport.Rows.Count - 1; i++)
                    {
                        _district = dgvImport.Rows[i].Cells[0].Value.ToString();
                        _city = dgvImport.Rows[i].Cells[1].Value.ToString();
                        _tvi = dgvImport.Rows[i].Cells[2].Value.ToString();
                        _qualification = dgvImport.Rows[i].Cells[3].Value.ToString();
                        _sector = dgvImport.Rows[i].Cells[4].Value.ToString();
                        _last_name = dgvImport.Rows[i].Cells[5].Value.ToString();
                        _first_name = dgvImport.Rows[i].Cells[6].Value.ToString();
                        _middle_name = dgvImport.Rows[i].Cells[7].Value.ToString();
                        _extension_name = dgvImport.Rows[i].Cells[8].Value.ToString();
                        _full_name = dgvImport.Rows[i].Cells[9].Value.ToString();
                        _scholarship_type = dgvImport.Rows[i].Cells[10].Value.ToString();
                        _training_status = dgvImport.Rows[i].Cells[11].Value.ToString();
                        _assessment_result = dgvImport.Rows[i].Cells[12].Value.ToString();
                        _emp_before_training = dgvImport.Rows[i].Cells[13].Value.ToString();
                        _occupation = dgvImport.Rows[i].Cells[14].Value.ToString();
                        _employer = dgvImport.Rows[i].Cells[15].Value.ToString();
                        _emp_type = dgvImport.Rows[i].Cells[16].Value.ToString();
                        _allocation = Convert.ToInt32(dgvImport.Rows[i].Cells[17].Value);
                        _verif_status = dgvImport.Rows[i].Cells[18].Value.ToString();
                        _verif_date = dgvImport.Rows[i].Cells[19].Value.ToString();
                        _referral_status = dgvImport.Rows[i].Cells[20].Value.ToString();
                        _company = dgvImport.Rows[i].Cells[21].Value.ToString();
                        _address = dgvImport.Rows[i].Cells[22].Value.ToString();
                        _job_title = dgvImport.Rows[i].Cells[23].Value.ToString();
                        _emp_date = dgvImport.Rows[i].Cells[24].Value.ToString();
                        _emp_status = dgvImport.Rows[i].Cells[25].Value.ToString();
                        _response_type = dgvImport.Rows[i].Cells[26].Value.ToString();
                        _follow_up = dgvImport.Rows[i].Cells[27].Value.ToString();
                        _answered = dgvImport.Rows[i].Cells[28].Value.ToString();
                        _reason_not_applying = dgvImport.Rows[i].Cells[29].Value.ToString();

                        command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@District", _district);
                        command.Parameters.AddWithValue("@City", _city);
                        command.Parameters.AddWithValue("@TVI", _tvi);
                        command.Parameters.AddWithValue("@Qualification", _qualification);
                        command.Parameters.AddWithValue("@Sector", _sector);
                        command.Parameters.AddWithValue("@Last_Name", _last_name);
                        command.Parameters.AddWithValue("@First_Name", _first_name);
                        command.Parameters.AddWithValue("@Middle_Name", _middle_name);
                        command.Parameters.AddWithValue("@Extension_Name", _extension_name);
                        command.Parameters.AddWithValue("@Full_Name", _full_name);
                        command.Parameters.AddWithValue("@Scholarship_Type", _scholarship_type);
                        command.Parameters.AddWithValue("@Training_Status", _training_status);
                        command.Parameters.AddWithValue("@Assessment_Result", _assessment_result);
                        command.Parameters.AddWithValue("@Emp_Before_Training", _emp_before_training);
                        command.Parameters.AddWithValue("@Occupation", _occupation);
                        command.Parameters.AddWithValue("@Employer", _employer);
                        command.Parameters.AddWithValue("@Emp_Type", _emp_type);
                        command.Parameters.AddWithValue("@Allocation", _allocation);
                        command.Parameters.AddWithValue("@Verif_Status", _verif_status);
                        command.Parameters.AddWithValue("@Verif_Date", _verif_date);
                        command.Parameters.AddWithValue("@Referral_Status", _referral_status);
                        command.Parameters.AddWithValue("@Company", _company);
                        command.Parameters.AddWithValue("@Address", _address);
                        command.Parameters.AddWithValue("@Job_Title", _job_title);
                        command.Parameters.AddWithValue("@Emp_Date", _emp_date);
                        command.Parameters.AddWithValue("@Emp_Status", _emp_status);
                        command.Parameters.AddWithValue("@Response_Type", _response_type);
                        command.Parameters.AddWithValue("@Follow_Up", _follow_up);
                        command.Parameters.AddWithValue("@Answered", _answered);
                        command.Parameters.AddWithValue("@Reason_Not_Applying", _reason_not_applying);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Excel data has been submitted to the database successfully.", "Data Submission");

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
