using MySqlConnector;
using System.Text;

namespace Scholarship_Employment
{
    public class Utilities
    {
        public static string MySqlConnectionString
        {
            get
            {
                MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
                mySqlConnectionStringBuilder.Server = "127.0.0.1";
                mySqlConnectionStringBuilder.Port = 3306;
                mySqlConnectionStringBuilder.UserID = "root";
                mySqlConnectionStringBuilder.Password = string.Empty;
                mySqlConnectionStringBuilder.Database = "tesda_etrak";

                return mySqlConnectionStringBuilder.ConnectionString;
            }
        }

        public static string DbTable { get => "graduates"; }

        // FrmFullName

        private void MiddleInitialFormat()
        {
            string _middle_initial = string.Empty;

            if (_middle_initial.Length == 2 && _middle_initial.Contains(".")) return;

            int removalLength = _middle_initial.Length - 2;
            StringBuilder builder = new StringBuilder(_middle_initial.ToUpper());
            builder.Remove(2, removalLength);

            string i = builder.ToString().Substring(1, 1);
            builder.Replace(i, ".");

            _middle_initial = builder.ToString();
        }

    }
}
