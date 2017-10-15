using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectionSQLServer
{
    public class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @".";

            string database = "QuanLySieuThi";
            string username = "QLST";
            string password = "123456";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
