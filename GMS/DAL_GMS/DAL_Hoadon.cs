using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_GMS
{
    public class DAL_Hoadon: DBConnection
    {   
        
        public int themHD(long makh,long thanhtien)
        {

            string str = string.Format("insert into hoadon(makh,trangthai,thanhtien) values('{0}','{1}','{2}'); select cast(scope_identity() as int)", makh, "False", thanhtien);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                //cmd.ExecuteNonQuery();
                int idhdthem = (int)cmd.ExecuteScalar();
                // hàm để lấy id vừa thêm
                con.Close();
                return idhdthem;
                
            }
            catch(Exception)
            {
                
                con.Close();
                return -1;
                // lỗi
            }
            
        }
        public DataTable xemHD()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from ViewHoadon", con);
            DataTable dtbHoadon = new DataTable();
            da.Fill(dtbHoadon);
            dtbHoadon.Columns.Add("stt");
            // ordinary : thu tu
            for (int i = 1; i <= dtbHoadon.Rows.Count; i++)
                dtbHoadon.Rows[i - 1]["stt"] = i.ToString();
            return dtbHoadon;
        }
        public DataTable xemHDtheoten(string tenkh)
        {
            DataTable daU = new DataTable();
            string str = "select * from ViewHoaDon where tenkh like '%" +tenkh+ "%'";
               // con.Open();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                
                da.Fill(daU);
                daU.Columns.Add("stt");
                // ordinary : thu tu
                for (int i = 1; i <= daU.Rows.Count; i++)
                    daU.Rows[i - 1]["stt"] = i.ToString();
                return daU;
 
        }
        public bool xacnhanHD(long mahd)
        {
            string str = string.Format("update hoadon set trangthai='True' where mahd='{0}'",mahd);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                
                con.Close();
                return true;

            }
            catch (Exception)
            {

                con.Close();
                return false;
                // lỗi
            }
        }
    }
}
