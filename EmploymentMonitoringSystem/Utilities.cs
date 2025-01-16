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

        public class Records
        {
            public Models.InitialRecord? Initial { get; set; }
            public Models.VerificationRecord? Verification { get; set; }
            public Models.EmploymentRecord? Employment { get; set; }

            public Records(Models.InitialRecord? initial, Models.VerificationRecord? verification, Models.EmploymentRecord? employment)
            {
                Initial = initial;
                Verification = verification;
                Employment = employment;
            }
        }
    }
}
