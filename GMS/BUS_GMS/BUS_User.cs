using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_GMS;
namespace BUS_GMS
{
    public class BUS_User
    {
        DAL_User dalUser = new DAL_User();
        public bool ktdn(string username, String password)
        {
            return dalUser.ktdnUser(username, password);
        }
    }
}
