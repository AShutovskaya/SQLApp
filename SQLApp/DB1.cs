using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp
{
    internal class DB1
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NKEH1AS\\SQLEXPRESS;Initial Catalog=App;" +
            "User ID=sa;Password=1234;TrustServerCertificate=true;");
        public void openConnection()
        {
           if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
