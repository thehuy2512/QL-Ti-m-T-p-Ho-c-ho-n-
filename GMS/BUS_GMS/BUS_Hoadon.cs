using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_GMS;
using System.Data;
namespace BUS_GMS
{
    public class BUS_Hoadon
    {
        DAL_Hoadon dalhd = new DAL_Hoadon();
        public int themHD(long makh,long thanhtien)
        {
            return dalhd.themHD(makh,thanhtien);
        }
        public DataTable xemHD()
        {
            return dalhd.xemHD();
        }
        public DataTable xemHDtheoten(string tenkh)
        {
            return dalhd.xemHDtheoten(tenkh);
        }
        public bool xacnhanHD(long mahd)
        {
            return dalhd.xacnhanHD(mahd);
        }
    }
}
