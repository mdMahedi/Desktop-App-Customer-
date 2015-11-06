using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DesktopApp
{
    class ConnectionClass
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString="Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=DeskTopAppDB;Data Source=MAHEDI";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
