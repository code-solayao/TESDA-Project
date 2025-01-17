﻿using MySqlConnector;
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
                mySqlConnectionStringBuilder.Server = "192.168.1.121";
                mySqlConnectionStringBuilder.Port = 3306;
                mySqlConnectionStringBuilder.UserID = "TesdaNCR";
                mySqlConnectionStringBuilder.Password = "Mysql.Tesda2024";
                mySqlConnectionStringBuilder.Database = "tesda_db";

                return mySqlConnectionStringBuilder.ConnectionString;
            }
        }

        public static string DbTable { get => "initial_records"; }

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
