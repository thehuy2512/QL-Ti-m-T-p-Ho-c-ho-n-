using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_GMS
{
    public class DAL_Hanghoa :DBConnection
    {
        public DataTable getHanghoa()
        {
            string str = "select * from hanghoa";
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
        public DataTable getHanghoaCon()
        {
            string str = "select * from hanghoa where trangthai='True'";
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
        public DataTable timkiemHh(string tenhang)
        {
            string str = "select * from hanghoa where tenhang like '%" + tenhang + "%'";
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
        public bool themHanghoa(string mahang, string tenhang, string loaihang, long soluong, long gia)
        {
            string str = string.Format("insert into hanghoa(mahang, tenhang, loaihang, soluong, gia, trangthai) values(N'{0}',N'{1}',N'{2}','{3}','{4}','True')", mahang,tenhang ,loaihang,soluong,gia);
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
        public bool ktMahang(string mahang)
        {
            string str = string.Format("SELECT * FROM hanghoa WHERE mahang='{0}'", mahang);
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(str, con);
                DataTable daU = new DataTable();
                da.Fill(daU);
               // for (int i = 1; i <= daU.Rows.Count; i++)
               //     daU.Rows[i - 1]["stt"] = i.ToString();
                // thêm vào thì coloumn stt nằm cuối cùng trong data grid view
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
        public bool suaHanghoa(string mahang, string tenhang, string loaihang, long soluong, long gia)
        {
            string str = string.Format("update hanghoa set tenhang=N'{0}',loaihang=N'{1}',soluong=N'{2}',gia=N'{3}' where mahang='{4}'", tenhang,loaihang,soluong,gia,mahang);
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
        public bool capnhattrangthaiHanghoa(bool trangthai,string mahang)
        {
            string str = string.Format("update hanghoa set trangthai=N'{0}' where mahang='{1}'", trangthai,mahang);
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
