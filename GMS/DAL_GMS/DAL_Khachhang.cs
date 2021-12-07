using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_GMS
{
    public class DAL_Khachhang: DBConnection
    {
        public DataTable getKhachhang()
        {
            string str = "select * from khachhang";
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataTable daU = new DataTable();
                da.Fill(daU);
                daU.Columns.Add("stt");
                for (int i = 1; i <= daU.Rows.Count; i++)
                    daU.Rows[i - 1]["stt"] = i.ToString();
                // thêm vào thì coloumn stt nằm cuối cùng trong data grid view
                if (daU.Rows.Count == 0)
                {
                    con.Close();
                    return null;
                }
                else
                {
                    con.Close();
                    return daU;
                }
            }
            catch
            {
                con.Close();
                return null;
            }
         
        }
        public DataTable timkiemKh(string tenkh)
        {
            string str = "select * from khachhang where tenkh like '%"+tenkh+"%'";
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataTable daU = new DataTable();
                da.Fill(daU);
                daU.Columns.Add("stt");
                for (int i = 1; i <= daU.Rows.Count; i++)
                    daU.Rows[i - 1]["stt"] = i.ToString();
                // thêm vào thì coloumn stt nằm cuối cùng trong data grid view
                if (daU.Rows.Count == 0)
                {
                    con.Close();
                    return null;
                }
                else
                {
                    con.Close();
                    return daU;
                }
            }
            catch
            {
                con.Close();
                return null;
            }

        }
        public bool themKhachhang(string tenkh,string sdt,string diachi)
        {
            string str = string.Format("insert into khachhang(tenkh, sdt, diachi) values(N'{0}',N'{1}',N'{2}')", tenkh, sdt, diachi);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

            }catch
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }
        public bool suaKhachhang(int makh,string tenkh,string sdt,string diachi)
        {
            string str = string.Format("update khachhang set tenkh=N'{0}',sdt=N'{1}',diachi=N'{2}' where makh='{3}'", tenkh, sdt, diachi, makh);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }
        
    }
}
