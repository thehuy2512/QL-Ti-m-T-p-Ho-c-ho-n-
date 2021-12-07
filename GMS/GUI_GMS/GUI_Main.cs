using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_GMS
{
    public partial class GUI_Main : Form
    {
        public GUI_Main()
        {
            InitializeComponent();
        }
        void Lock_Unlock(bool kt)
        {
            mnuLogout.Enabled = mnuManager.Enabled = mnuBill.Enabled = !kt;
            mnuLogin.Enabled = mnuClose.Enabled = kt;
        }

        private void GUI_Main_Activated(object sender, EventArgs e)
        {
           Lock_Unlock(Luu.KT);
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            GUI_Login frmLogin = new GUI_Login();
            frmLogin.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Lock_Unlock(!Luu.KT);
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            GUI_Hanghoa frmhh = new GUI_Hanghoa();
            frmhh.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            GUI_KhachHang frmkh = new GUI_KhachHang();
            frmkh.Show();
        }

        private void mnuThemhd_Click(object sender, EventArgs e)
        {
            GUI_HoaDon frmhd = new GUI_HoaDon();
            frmhd.Show();
        }

        private void mnuXemhd_Click(object sender, EventArgs e)
        {

        }

        private void mnuThemhd_Click_1(object sender, EventArgs e)
        {
            GUI_HoaDon frmhd = new GUI_HoaDon();
            frmhd.Show();
        }

        private void mnuXemhd_Click_1(object sender, EventArgs e)
        {
            GUI_XemHoaDon frmxhd = new GUI_XemHoaDon();
            frmxhd.Show();
        }
    }
}
