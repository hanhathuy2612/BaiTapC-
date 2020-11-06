using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_3_Lap4.Connection
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source = LAPTOP-L0GIISLN\\SQLEXPRESS; Initial Catalog = SINHVIEN7;" +
                "UID = sa; PWD=demo123";
            /*conStr = "Data Source = LAPTOP-L0GIISLN\\SQLEXPRESS; Intial Catalog = QUANLYSINHVIEN_WF; Integrated Security=true";*/
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
