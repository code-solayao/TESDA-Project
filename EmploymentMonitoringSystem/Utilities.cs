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
                mySqlConnectionStringBuilder.Server = "localhost";
                //mySqlConnectionStringBuilder.Port = 3306;
                mySqlConnectionStringBuilder.UserID = "root";
                mySqlConnectionStringBuilder.Password = string.Empty;
                mySqlConnectionStringBuilder.Database = "tesda_etrak_db";

                return mySqlConnectionStringBuilder.ConnectionString;
            }
        }
    }
}
