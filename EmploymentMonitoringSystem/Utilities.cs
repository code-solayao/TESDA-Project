using MySqlConnector;

namespace EmploymentMonitoringSystem
{
    public class Utilities
    {
        public static string MySqlConnectionString
        {
            get
            {
                MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
                mySqlConnectionStringBuilder.Server = "192.168.1.121";
                mySqlConnectionStringBuilder.Port = 3306;
                mySqlConnectionStringBuilder.UserID = "TesdaNCR";
                mySqlConnectionStringBuilder.Password = "Mysql.Tesda2024";
                mySqlConnectionStringBuilder.Database = "employment_monitoring_system";

                return mySqlConnectionStringBuilder.ConnectionString;
            }
        }

        public class DataRecordTable
        {
            public required List<Models.InitialRecord> InitialRecords { get; set; }
            public required List<Models.EmploymentRecord> EmploymentRecords { get; set; }
        }
    }
}
