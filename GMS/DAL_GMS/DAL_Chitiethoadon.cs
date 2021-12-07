using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_GMS
{
    public class DAL_Chitiethoadon:DBConnection
    {
        public bool themCthd(string mahang, long soluongmua, int mahd)
        {
            
            string str = string.Format("insert into chitiethoadon(mahang,soluongmua,mahd) values(N'{0}','{1}',{2})", mahang,soluongmua,mahd);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                con.Close();
                return false;
                // lỗi
            }

        }
        public DataTable xemCTHD(long mahd)
        {
            DataTable daU = new DataTable();
            string str = "select * from ViewCTHD  where mahd ='"+mahd+"'";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                
                da.Fill(daU);
                daU.Columns.Add("stt");
                // ordinary : thu tu
                for (int i = 1; i <= daU.Rows.Count; i++)
                    daU.Rows[i - 1]["stt"] = i.ToString();
                return daU;
        }
    }
}
