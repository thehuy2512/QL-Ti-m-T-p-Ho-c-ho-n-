using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_GMS;
using System.Data;
namespace BUS_GMS
{
    public class BUS_Chitiethoadon
    {
        DAL_Chitiethoadon dalcthd = new DAL_Chitiethoadon();
        public bool themCthd(string mahang, long soluongmua, int mahd)
        {
            return dalcthd.themCthd(mahang, soluongmua, mahd);
        }
        public DataTable xemCTHD(long mahd)
        {
            return dalcthd.xemCTHD(mahd);
        }
    }
}
