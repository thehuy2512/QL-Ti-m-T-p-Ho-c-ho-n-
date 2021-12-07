using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_GMS
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection("server=DESKTOP-CUNAA3I\\SQLEXPRESS;uid=sa;pwd=123;database=GMD");
    }
}
