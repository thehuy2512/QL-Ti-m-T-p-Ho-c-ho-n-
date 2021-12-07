using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_GMS;
namespace BUS_GMS
{   
    
    public class BUS_Khachhang
    {
        DAL_Khachhang dalkh = new DAL_Khachhang();
        public DataTable getKhachhang()
        {
            return dalkh.getKhachhang();
        }
        public DataTable timkiemKh(string tenkh)
        {
            return dalkh.timkiemKh(tenkh);
        }
        public bool themKhachhang(string tenkh, string sdt, string diachi)
        {
            return dalkh.themKhachhang(tenkh, sdt, diachi);
        }
        public bool suaKhachhang(int makh, string tenkh, string sdt, string diachi)
        {
            return dalkh.suaKhachhang(makh, tenkh, sdt, diachi);
        }
    }
}
