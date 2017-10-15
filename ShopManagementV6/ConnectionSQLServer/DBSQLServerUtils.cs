using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectionSQLServer
{
    public class DBSQLServerUtils
    {
        public static SqlConnection
                GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True
            //
            string connString = "Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
