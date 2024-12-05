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
        private string _qualification_title;
        private string _sector;
        private string _last_name;
        private string _first_name;
        private string _middle_name;
        private string _extension_name;
        private string _full_name;
        private string _contact_number;
        private string _email;
        private string _scholarship_type;
        private string _address;
        private string _allocation;

        private string _verification_means;
        private string _verification_status;
        private string _verification_date;
        private string _follow_up_date;
        private string _response_status;
        private string _not_interested_reason;
        private string _referral_status;

        private string _company_name;
        private string _company_address;
        private string _job_title;
        private string _employment_status;
        private string _hired_date;

        private string _training_status;
        private string _assessment_result;
        private string _employment_before_training;
        private string _occupation;
        private string _employer_name;
        private string _employment_type;
        private string _date_hired;

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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitToDatabase();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

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

                    string sql = $"CALL exceldata_import(@district, @city, @tvi, @qualification_title, @sector, @last_name, @first_name, " +
                        $"@middle_name, @extension_name, @full_name, @contact_number, @email, @scholarship_type, @training_status, " +
                        $"@assessment_result, @employment_before_training, @occupation, @employer_name, @employment_type, @address, " +
                        $"@date_hired, @allocation, @verification_means, @verification_date, @verification_status, @follow_up_date, " +
                        $"@response_status, @not_interested_reason, @referral_status, @company_name, @company_address, @job_title, " +
                        $"@employment_status, @hired_date);";

                    MySqlCommand command = null;
                    for (int i = 0; i < dgvImport.Rows.Count - 1; i++)
                    {
                        _district = dgvImport.Rows[i].Cells[0].Value.ToString();
                        _city = dgvImport.Rows[i].Cells[1].Value.ToString();
                        _tvi = dgvImport.Rows[i].Cells[2].Value.ToString();
                        _qualification_title = dgvImport.Rows[i].Cells[3].Value.ToString();
                        _sector = dgvImport.Rows[i].Cells[4].Value.ToString();
                        _last_name = dgvImport.Rows[i].Cells[5].Value.ToString();
                        _first_name = dgvImport.Rows[i].Cells[6].Value.ToString(); 
                        _middle_name = dgvImport.Rows[i].Cells[7].Value.ToString();
                        _extension_name = dgvImport.Rows[i].Cells[8].Value.ToString();
                        _full_name = dgvImport.Rows[i].Cells[9].Value.ToString();
                        _contact_number = dgvImport.Rows[i].Cells[10].Value.ToString();
                        _email = dgvImport.Rows[i].Cells[11].Value.ToString();
                        _scholarship_type = dgvImport.Rows[i].Cells[12].Value.ToString();
                        _training_status = dgvImport.Rows[i].Cells[13].Value.ToString();
                        _assessment_result = dgvImport.Rows[i].Cells[14].Value.ToString();
                        _employment_before_training = dgvImport.Rows[i].Cells[15].Value.ToString();
                        _occupation = dgvImport.Rows[i].Cells[16].Value.ToString();
                        _employer_name = dgvImport.Rows[i].Cells[17].Value.ToString();
                        _employment_type = dgvImport.Rows[i].Cells[18].Value.ToString();
                        _address = dgvImport.Rows[i].Cells[19].Value.ToString();
                        _date_hired = dgvImport.Rows[i].Cells[20].Value.ToString();
                        _allocation = dgvImport.Rows[i].Cells[21].Value.ToString();

                        _verification_means = dgvImport.Rows[i].Cells[22].Value.ToString();
                        _verification_date = dgvImport.Rows[i].Cells[23].Value.ToString();
                        _verification_status = dgvImport.Rows[i].Cells[24].Value.ToString();
                        _follow_up_date = dgvImport.Rows[i].Cells[25].Value.ToString();
                        _response_status = dgvImport.Rows[i].Cells[26].Value.ToString();
                        _not_interested_reason = dgvImport.Rows[i].Cells[27].Value.ToString();
                        _referral_status = dgvImport.Rows[i].Cells[28].Value.ToString();

                        _company_name = dgvImport.Rows[i].Cells[29].Value.ToString();
                        _company_address = dgvImport.Rows[i].Cells[30].Value.ToString();
                        _job_title = dgvImport.Rows[i].Cells[31].Value.ToString();
                        _employment_status = dgvImport.Rows[i].Cells[32].Value.ToString();
                        _hired_date = dgvImport.Rows[i].Cells[33].Value.ToString();
                        
                        command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@district", _district);
                        command.Parameters.AddWithValue("@city", _city);
                        command.Parameters.AddWithValue("@tvi", _tvi);
                        command.Parameters.AddWithValue("@qualification_title", _qualification_title);
                        command.Parameters.AddWithValue("@sector", _sector);
                        command.Parameters.AddWithValue("@last_name", _last_name);
                        command.Parameters.AddWithValue("@first_name", _first_name);
                        command.Parameters.AddWithValue("@middle_name", _middle_name);
                        command.Parameters.AddWithValue("@extension_name", _extension_name);
                        command.Parameters.AddWithValue("@full_name", _full_name);
                        command.Parameters.AddWithValue("@contact_number", _contact_number);
                        command.Parameters.AddWithValue("@email", _email);
                        command.Parameters.AddWithValue("@scholarship_type", _scholarship_type);
                        command.Parameters.AddWithValue("@training_status", _training_status);
                        command.Parameters.AddWithValue("@assessment_result", _assessment_result);
                        command.Parameters.AddWithValue("@employment_before_training", _employment_before_training);
                        command.Parameters.AddWithValue("@occupation", _occupation);
                        command.Parameters.AddWithValue("@employer_name", _employer_name);
                        command.Parameters.AddWithValue("@employment_type", _employment_type);
                        command.Parameters.AddWithValue("@address", _address);
                        command.Parameters.AddWithValue("@date_hired", _date_hired);
                        command.Parameters.AddWithValue("@allocation", _allocation);

                        command.Parameters.AddWithValue("@verification_means", _verification_means);
                        command.Parameters.AddWithValue("@verification_date", _verification_date);
                        command.Parameters.AddWithValue("@verification_status", _verification_status);
                        command.Parameters.AddWithValue("@follow_up_date", _follow_up_date);
                        command.Parameters.AddWithValue("@response_status", _response_status);
                        command.Parameters.AddWithValue("not_interested_reason", _not_interested_reason);
                        command.Parameters.AddWithValue("@referral_status", _referral_status);

                        command.Parameters.AddWithValue("@company_name", _company_name);
                        command.Parameters.AddWithValue("@company_address", _company_address);
                        command.Parameters.AddWithValue("@job_title", _job_title);
                        command.Parameters.AddWithValue("@employment_status", _employment_status);
                        command.Parameters.AddWithValue("@hired_date", _hired_date);
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
