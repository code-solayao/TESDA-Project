using MySqlConnector;

namespace Scholarship_Employment
{
    public class Utilities
    {
        public static string MySqlConnectionString
        {
            get
            {
                MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
                mySqlConnectionStringBuilder.Server = "localhost";
                mySqlConnectionStringBuilder.UserID = "root";
                mySqlConnectionStringBuilder.Password = "Mysql.Tesda2024";
                mySqlConnectionStringBuilder.Database = "tesda_db";

                return mySqlConnectionStringBuilder.ConnectionString;
            }
        }
    }
}
