using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BUS_GMS;
namespace GUI_GMS
{
    public partial class GUI_XemHoaDon : Form
    {
        BUS_Hoadon bushd = new BUS_Hoadon();
        BUS_Chitiethoadon buscthd = new BUS_Chitiethoadon();
        long tammahd;
        public GUI_XemHoaDon()
        {
            InitializeComponent();
            loadHoaDon();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void loadHoaDon()
        {
            dgvXemHD.DataSource = bushd.xemHD();
        }
        public void loadCTHoaDon(long mahd)
        {
            dgvXemcthd.DataSource = buscthd.xemCTHD(mahd);
        }
        private void dgvXemHD_Click(object sender, EventArgs e)
        {
            int i = dgvXemHD.CurrentRow.Index;
            tammahd = long.Parse(dgvXemHD.Rows[i].Cells["mahd"].Value.ToString());
            txtMahd.Text = tammahd.ToString();
            string tamtrangthai = dgvXemHD.Rows[i].Cells["trangthai"].Value.ToString();
            if (tamtrangthai.Equals("False"))
            {
                txtTrangthai.Text = "Chưa thanh toán";
            }
            else
            {
                txtTrangthai.Text = "Đã thanh toán";
            }
            txtTongtien.Text = dgvXemHD.Rows[i].Cells["thanhtien"].Value.ToString();
            loadCTHoaDon(tammahd);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string timten = txtTimkiem.Text;
            dgvXemHD.DataSource = bushd.xemHDtheoten(timten);
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool xacnhanhd = bushd.xacnhanHD(tammahd);
            if (xacnhanhd == true)
            {
                MessageBox.Show("Đã thanh toán!", "Xác nhận hoá đơn");
            }
            else
            {
                MessageBox.Show("Chưa thanh toán!", "Info");
            }
            txtTrangthai.Text = "Đã thanh toán!";
            loadHoaDon();
        }
    }
}
