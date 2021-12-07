using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_GMS;
namespace BUS_GMS
{
    public class BUS_Hanghoa
    {
        DAL_Hanghoa dalhh = new DAL_Hanghoa();
        public DataTable getHanghoa()
        {
            return dalhh.getHanghoa();
        }
        public DataTable timkiemHh(string tenhang)
        {
            return dalhh.timkiemHh(tenhang);
        }
        public bool themHanghoa(string mahang, string tenhang, string loaihang, long soluong, long gia)
        {
            return dalhh.themHanghoa(mahang, tenhang, loaihang, soluong, gia);
        }
        public bool ktMahang(string mahang)
        {
            return dalhh.ktMahang(mahang);
        }
        public bool suaHanghoa(string mahang, string tenhang, string loaihang, long soluong, long gia)
        {
            return dalhh.suaHanghoa(mahang, tenhang, loaihang, soluong, gia);
        }
        public bool capnhattrangthaiHanghoa(bool trangthai, string mahang)
        {
            return dalhh.capnhattrangthaiHanghoa(trangthai, mahang);
        }
        public DataTable getHanghoaCon()
        {
            return dalhh.getHanghoaCon();
        }
    }
}
