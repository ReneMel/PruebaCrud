using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace System.DData
{
    public class Connection
    {
        private string dbName;
        private string serverName;
        private string dbUser;
        private string dbKeyCode;
        private bool dbSecurity;
        private static Connection instance = null;

        private Connection()
        {
            this.dbName = "pruebaCRUD";
            this.serverName = "DESKTOP-JB2D4KF";
            this.dbUser = "admin";
            this.dbKeyCode = "admin";
            this.dbSecurity = true; // SQL or Windows authentication
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = "Server=" + this.serverName + "; Database=" + this.dbName + ";";

                if (this.dbSecurity)
                {
                    connection.ConnectionString = connection.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    connection.ConnectionString = connection.ConnectionString + "User Id=" + this.dbUser + "; Password=" + this.dbKeyCode;

                }

            }
            catch (Exception)
            {
                throw;
            }

            return connection;
        }

        public static Connection GetInstance()
        {
            if (instance == null)
                instance = new Connection();

            return instance;
        }

    }
}
