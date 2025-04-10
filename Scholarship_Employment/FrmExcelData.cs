using MySqlConnector;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class FrmExcelData : Form
    {
        #region Fields

        private string _created_at;
        private string _updated_at;

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
        private string _sex;
        private string _birthdate;
        private string _contact_number;
        private string _email;
        private string _address;
        private string _scholarship_type;
        private string _training_status;
        private string _assessment_result;
        private string _employment_before_training;
        private string _occupation;
        private string _employer_name;
        private string _employment_type;
        private string _work_address;
        private string _date_hired;
        private string _allocation;

        private string _verification_means;
        private string _verification_date;
        private string _verification_status;
        private string _follow_up_date_1;
        private string _follow_up_date_2;
        private string _response_status;
        private string _not_interested_reason;
        private string _referral_status;
        private string _referral_date;
        private string _no_referral_reason;
        private string _invalid_contact;

        private string _company_name;
        private string _company_address;
        private string _job_title;
        private string _application_status;
        private string _withdrawn_reason;
        private string _employment_status;
        private string _hired_date;
        private string _submitted_documents_date;
        private string _interview_date;
        private string _not_hired_reason;

        private string _count;
        private string _no_of_graduates;
        private string _no_of_employed;
        private string _verification;
        private string _job_vacancies;
        private string _remarks;

        #endregion

        public FrmExcelData()
        {
            InitializeComponent();

            MdiParent = Form1.Instance;
        }

        private void FrmExcelData_Load(object sender, EventArgs e)
        {
            lblLoading.Text = string.Empty;
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

                    string sheet = null;
                    string sheetName = "List of Graduates";

                    DataTable sheets = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (sheets != null && sheets.Rows.Count > 0)
                    {
                        foreach (DataRow row in sheets.Rows)
                        {
                            if (row["TABLE_NAME"].ToString().Contains(sheetName))
                                sheet = row["TABLE_NAME"].ToString();
                        }
                    }
                    else MessageBox.Show("No sheets found in the Excel file.", "No Sheets Found");
                    //DataTable dataTableExcel = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    //string sheetName = dataTableExcel.Rows[2]["TABLE_NAME"].ToString();

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
            lblLoading.Text = "Loading...";
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = string.Empty;
                    MySqlCommand command = null;

                    for (int i = 0; i < dgvImport.Rows.Count; i++)
                    {
                        _created_at = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                        _updated_at = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");

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
                        _sex = DataGridView_CellString(i, 10);
                        _birthdate = DataGridView_CellString(i, 11);
                        _contact_number = DataGridView_CellString(i, 12);
                        _email = DataGridView_CellString(i, 13);
                        _address = DataGridView_CellString(i, 14);
                        _scholarship_type = DataGridView_CellString(i, 15);
                        _training_status = DataGridView_CellString(i, 16);
                        _assessment_result = DataGridView_CellString(i, 17);
                        _employment_before_training = DataGridView_CellString(i, 18);
                        _occupation = DataGridView_CellString(i, 19);
                        _employer_name = DataGridView_CellString(i, 20);
                        _employment_type = DataGridView_CellString(i, 21);
                        _work_address = DataGridView_CellString(i, 22);
                        _date_hired = DataGridView_CellStringDate(i, 23);
                        _allocation = DataGridView_CellString(i, 24);

                        _verification_means = DataGridView_CellString(i, 25);
                        _verification_date = DataGridView_CellStringDate(i, 26);
                        _verification_status = DataGridView_CellString(i, 27);
                        _follow_up_date_1 = DataGridView_CellStringDate(i, 28);
                        _follow_up_date_2 = string.Empty;
                        _response_status = DataGridView_CellString(i, 29);
                        _not_interested_reason = DataGridView_CellString(i, 30);
                        _referral_status = DataGridView_CellString(i, 31);
                        _referral_date = string.Empty;
                        _no_referral_reason = string.Empty;
                        _invalid_contact = string.Empty;

                        _company_name = DataGridView_CellString(i, 32);
                        _company_address = DataGridView_CellString(i, 33);
                        _job_title = DataGridView_CellString(i, 34);
                        _employment_status = DataGridView_CellString(i, 35);
                        _hired_date = DataGridView_CellStringDate(i, 36);
                        _submitted_documents_date = string.Empty;
                        _interview_date = string.Empty;
                        _not_hired_reason = DataGridView_CellString(i, 37);

                        _count = DataGridView_CellString(i, 38);
                        _no_of_graduates = DataGridView_CellString(i, 39);
                        _no_of_employed = DataGridView_CellString(i, 40);
                        _verification = DataGridView_CellString(i, 41);
                        _job_vacancies = DataGridView_CellString(i, 42);
                        _remarks = DataGridView_CellString(i, 43);
                        _application_status = DataGridView_CellString(i, 44);
                        _withdrawn_reason = string.Empty;

                        if (String.IsNullOrEmpty(_last_name) && String.IsNullOrEmpty(_first_name) && String.IsNullOrEmpty(_full_name)) 
                            continue;

                        sql = "CALL import_records(" +
                            "@created_at, @updated_at, @district, @city, @tvi, " +
                            "@qualification_title, @sector, @last_name, @first_name, @middle_name, " +
                            "@extension_name, @full_name, @sex, @birthdate, @contact_number, " +
                            "@email, @address, @scholarship_type, @training_status, @assessment_result, " +
                            "@employment_before_training, @occupation, @employer_name, @employment_type, @work_address, " +
                            "@date_hired, @allocation, @verification_means, @verification_date, @verification_status, " +
                            "@follow_up_date_1, @follow_up_date_2, @response_status, @not_interested_reason, @referral_status, " +
                            "@referral_date, @no_referral_reason, @invalid_contact, @company_name, @company_address, " +
                            "@job_title, @application_status, @withdrawn_reason, @employment_status, @hired_date, " +
                            "@submitted_documents_date, @interview_date, @not_hired_reason, @count, @no_of_graduates, " +
                            "@no_of_employed, @verification, @job_vacancies, @remarks);";
                        command = new MySqlCommand(sql, connection);

                        command.Parameters.AddWithValue("@created_at", _created_at);
                        command.Parameters.AddWithValue("@updated_at", _updated_at);
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
                        command.Parameters.AddWithValue("@sex", _sex);
                        command.Parameters.AddWithValue("@birthdate", _birthdate);
                        command.Parameters.AddWithValue("@contact_number", _contact_number);

                        command.Parameters.AddWithValue("@email", _email);
                        command.Parameters.AddWithValue("@address", _address);
                        command.Parameters.AddWithValue("@scholarship_type", _scholarship_type);
                        command.Parameters.AddWithValue("@training_status", _training_status);
                        command.Parameters.AddWithValue("@assessment_result", _assessment_result);

                        command.Parameters.AddWithValue("@employment_before_training", _employment_before_training);
                        command.Parameters.AddWithValue("@occupation", _occupation);
                        command.Parameters.AddWithValue("@employer_name", _employer_name);
                        command.Parameters.AddWithValue("@employment_type", _employment_type);
                        command.Parameters.AddWithValue("@work_address", _work_address);

                        command.Parameters.AddWithValue("@date_hired", _date_hired);
                        command.Parameters.AddWithValue("@allocation", _allocation);
                        command.Parameters.AddWithValue("@verification_means", _verification_means);
                        command.Parameters.AddWithValue("@verification_date", _verification_date);
                        command.Parameters.AddWithValue("@verification_status", _verification_status);

                        command.Parameters.AddWithValue("@follow_up_date_1", _follow_up_date_1);
                        command.Parameters.AddWithValue("@follow_up_date_2", _follow_up_date_2);
                        command.Parameters.AddWithValue("@response_status", _response_status);
                        command.Parameters.AddWithValue("@not_interested_reason", _not_interested_reason);
                        command.Parameters.AddWithValue("@referral_status", _referral_status);

                        command.Parameters.AddWithValue("@referral_date", _referral_date);
                        command.Parameters.AddWithValue("@no_referral_reason", _no_referral_reason);
                        command.Parameters.AddWithValue("@invalid_contact", _invalid_contact);
                        command.Parameters.AddWithValue("@company_name", _company_name);
                        command.Parameters.AddWithValue("@company_address", _company_address);

                        command.Parameters.AddWithValue("@job_title", _job_title);
                        command.Parameters.AddWithValue("@application_status", _application_status);
                        command.Parameters.AddWithValue("@withdrawn_reason", _withdrawn_reason);
                        command.Parameters.AddWithValue("@employment_status", _employment_status);
                        command.Parameters.AddWithValue("@hired_date", _hired_date);

                        command.Parameters.AddWithValue("@submitted_documents_date", _submitted_documents_date);
                        command.Parameters.AddWithValue("@interview_date", _interview_date);
                        command.Parameters.AddWithValue("@not_hired_reason", _not_hired_reason);
                        command.Parameters.AddWithValue("@count", _count);
                        command.Parameters.AddWithValue("@no_of_graduates", _no_of_graduates);

                        command.Parameters.AddWithValue("@no_of_employed", _no_of_employed);
                        command.Parameters.AddWithValue("@verification", _verification);
                        command.Parameters.AddWithValue("@job_vacancies", _job_vacancies);
                        command.Parameters.AddWithValue("@remarks", _remarks);

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
            lblLoading.Text = string.Empty;
        }

        private string DataGridView_CellString(int row, int cell)
        {
            object cellValue = dgvImport.Rows[row].Cells[cell].Value;
            if (cellValue == null) return string.Empty;

            string value = cellValue.ToString();
            switch (cell)
            {
                case 37:
                    // Status of Employment
                    if (value.Contains("Requirements"))
                        value = "Submitted Documents";
                    break;
                case 39:
                    // Not Hired (Reason)
                    if (value.Equals("Overage"))
                        value = "Underage";
                    else if (value.Equals("Not Yet Qualified"))
                        value = "Did not meet the requirements";
                    break;
            }

            return value;
        }

        private string DataGridView_CellStringDate(int row, int cell)
        {
            object cellValue = dgvImport.Rows[row].Cells[cell].Value;
            if (cellValue == null) return string.Empty;

            string value = cellValue.ToString();
            if (DateTime.TryParse(value, out DateTime parsedDate))
                return parsedDate.ToString("yyyy-MM-dd");

            if (value.Length != 5) return value;
            if (int.TryParse(value, out int parsedInt))
            {
                DateTime excelBaseDate = new DateTime(1899, 12, 30);
                DateTime convertedDate = excelBaseDate.AddDays(parsedInt);
                return convertedDate.ToString("yyyy-MM-dd");
            }

            return value;
        }
    }
}
