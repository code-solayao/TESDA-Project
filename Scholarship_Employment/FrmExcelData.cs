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
        private string _remarks;
        private string _count;
        private string _no_of_graduates;
        private string _no_of_employed;
        private string _verification;
        private string _job_vacancies;

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

        private void SubmitToDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = string.Empty;
                    int Id = 0;
                    MySqlCommand command = null;

                    for (int i = 0; i < dgvImport.Rows.Count; i++)
                    {
                        _district = DataGridView_CellString(i, 0);
                        _city = DataGridView_CellString(i, 1);
                        _tvi = DataGridView_CellString(i, 2);
                        _qualification_title = DataGridView_CellString(i, 3);
                        _sector = DataGridView_CellString(i, 4);
                        _last_name = DataGridView_CellString(i, 5);
                        _first_name = DataGridView_CellString(i, 6); 
                        _middle_name = DataGridView_CellString(i, 7);
                        _extension_name = DataGridView_CellString(i, 8);
                        _full_name = DataGridView_CellString(i, 9);
                        _contact_number = DataGridView_CellString(i, 10);
                        _email = DataGridView_CellString(i, 11);
                        _scholarship_type = DataGridView_CellString(i, 12);
                        _address = DataGridView_CellString(i, 19);
                        _allocation = DataGridView_CellString(i, 21);

                        _verification_means = DataGridView_CellString(i, 22);
                        _verification_date = DataGridView_CellString(i, 23);
                        _verification_status = DataGridView_CellString(i, 24);
                        _follow_up_date = DataGridView_CellString(i, 25);
                        _response_status = DataGridView_CellString(i, 26);
                        _not_interested_reason = DataGridView_CellString(i, 27);
                        _referral_status = DataGridView_CellString(i, 28);

                        _company_name = DataGridView_CellString(i, 29);
                        _company_address = DataGridView_CellString(i, 30);
                        _job_title = DataGridView_CellString(i, 31);
                        _employment_status = DataGridView_CellString(i, 32);
                        _hired_date = DataGridView_CellString(i, 33);

                        _training_status = DataGridView_CellString(i, 13);
                        _assessment_result = DataGridView_CellString(i, 14);
                        _employment_before_training = DataGridView_CellString(i, 15);
                        _occupation = DataGridView_CellString(i, 16);
                        _employer_name = DataGridView_CellString(i, 17);
                        _employment_type = DataGridView_CellString(i, 18);
                        _date_hired = DataGridView_CellString(i, 20);
                        _remarks = DataGridView_CellString(i, 34);
                        _count = DataGridView_CellString(i, 35);
                        _no_of_graduates = DataGridView_CellString(i, 36);
                        _no_of_employed = DataGridView_CellString(i, 37);
                        _verification = DataGridView_CellString(i, 38);
                        _job_vacancies = DataGridView_CellString(i, 39);

                        sql = "CALL submit_record_data(@district, @city, @tvi, @qualification_title, @sector, @last_name, @first_name, " +
                            "@middle_name, @extension_name, @full_name, @sex, @birthdate, @contact_number, @email, @scholarship_type, " +
                            "@address, @allocation);";
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
                        command.Parameters.AddWithValue("@sex", string.Empty);
                        command.Parameters.AddWithValue("@birthdate", string.Empty);
                        command.Parameters.AddWithValue("@contact_number", _contact_number);
                        command.Parameters.AddWithValue("@email", _email);
                        command.Parameters.AddWithValue("@scholarship_type", _scholarship_type);
                        command.Parameters.AddWithValue("@address", _address);
                        command.Parameters.AddWithValue("@allocation", _allocation);
                        command.ExecuteNonQuery();

                        sql = "CALL get_new_record_id(@last_name, @first_name);";
                        command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@last_name", _last_name);
                        command.Parameters.AddWithValue("@first_name", _first_name);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Id = reader.GetInt32(0);
                            }
                        }

                        sql = "CALL exceldata_import(@Id, @verification_means, @verification_date, @verification_status, " +
                            "@follow_up_date_1, @follow_up_date_2, @response_status, @not_interested_reason, @referral_status, " +
                            "@referral_date, @no_referral_reason, @invalid_contact, @company_name, @company_address, @job_title, " +
                            "@employment_status, @hired_date, @submitted_documents_date, @interview_date, @not_hired_reason, " +
                            "@training_status, @assessment_result, @employment_before_training, @occupation, @employer_name, " +
                            "@employment_type, @date_hired, @remarks, @count, @no_of_graduates, @no_of_employed, @verification, " +
                            "@job_vacancies);";
                        command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@verification_means", _verification_means);
                        command.Parameters.AddWithValue("@verification_date", _verification_date);
                        command.Parameters.AddWithValue("@verification_status", _verification_status);
                        command.Parameters.AddWithValue("@follow_up_date_1", _follow_up_date);
                        command.Parameters.AddWithValue("@follow_up_date_2", string.Empty);
                        command.Parameters.AddWithValue("@response_status", _response_status);
                        command.Parameters.AddWithValue("not_interested_reason", _not_interested_reason);
                        command.Parameters.AddWithValue("@referral_status", _referral_status);
                        command.Parameters.AddWithValue("@referral_date", string.Empty);
                        command.Parameters.AddWithValue("@no_referral_reason", string.Empty);
                        command.Parameters.AddWithValue("@invalid_contact", string.Empty);

                        command.Parameters.AddWithValue("@company_name", _company_name);
                        command.Parameters.AddWithValue("@company_address", _company_address);
                        command.Parameters.AddWithValue("@job_title", _job_title);
                        command.Parameters.AddWithValue("@employment_status", _employment_status);
                        command.Parameters.AddWithValue("@hired_date", _hired_date);
                        command.Parameters.AddWithValue("@submitted_documents_date", string.Empty);
                        command.Parameters.AddWithValue("@interview_date", string.Empty);
                        command.Parameters.AddWithValue("@not_hired_reason", string.Empty);

                        command.Parameters.AddWithValue("@training_status", _training_status);
                        command.Parameters.AddWithValue("@assessment_result", _assessment_result);
                        command.Parameters.AddWithValue("@employment_before_training", _employment_before_training);
                        command.Parameters.AddWithValue("@occupation", _occupation);
                        command.Parameters.AddWithValue("@employer_name", _employer_name);
                        command.Parameters.AddWithValue("@employment_type", _employment_type);
                        command.Parameters.AddWithValue("@date_hired", _date_hired);
                        command.Parameters.AddWithValue("@remarks", _remarks);
                        command.Parameters.AddWithValue("@count", _count);
                        command.Parameters.AddWithValue("@no_of_graduates", _no_of_graduates);
                        command.Parameters.AddWithValue("@no_of_employed", _no_of_employed);
                        command.Parameters.AddWithValue("@verification", _verification);
                        command.Parameters.AddWithValue("@job_vacancies", _job_vacancies);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Excel data has been submitted to the database successfully.", "Data Submission");

                    connection.Close();
                }
                catch (FieldAccessException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }

        private string DataGridView_CellString(int row, int cell)
        {
            object cellValue = dgvImport.Rows[row].Cells[cell].Value;

            if (cellValue == null) return string.Empty;
            else return cellValue.ToString();
        }
    }
}
