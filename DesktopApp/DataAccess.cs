using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    class DataAccess
    {
        public DataTable SelectFromCustomers()
        {
            SqlConnection conn = ConnectionClass.GetSqlConnection();
            string query = "select * from [dbo].[Customers]";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public bool InsertIntoCustomers(string name, string adrs, string mail, string phon)
        {
            SqlConnection conn = ConnectionClass.GetSqlConnection();
            string query = "insert into [dbo].[Customers] values ('"+name+"','"+adrs+"','"+mail+"','"+phon+"')";
            SqlCommand comnd = new SqlCommand(query, conn);
            if (comnd.ExecuteNonQuery() > 0)
                return true;
            else return false;
        }
    }
}
