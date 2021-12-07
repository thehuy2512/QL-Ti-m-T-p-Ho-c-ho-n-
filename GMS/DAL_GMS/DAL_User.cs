using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_GMS
{
    public class DAL_User : DBConnection
    {
        public bool ktdnUser(string username, string password)
        {
            string str = string.Format("SELECT * FROM dangnhap WHERE tendn='{0}' and matkhau='{1}'", username, password);
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataTable daU = new DataTable();
                da.Fill(daU);
                if (daU.Rows.Count == 0)
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }

            }
            catch
            {
                con.Close();
                return false;
            }
        }
    }
}
