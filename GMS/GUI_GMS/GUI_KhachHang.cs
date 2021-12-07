using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_GMS;
namespace GUI_GMS
{
    public partial class GUI_KhachHang : Form
    {
        BUS_Khachhang buskh = new BUS_Khachhang();
        int makhsua;
        public GUI_KhachHang()
        {
            InitializeComponent();
            LoadTableKh();
        }
        void LoadTableKh()
        {
            dgvKhachhang.DataSource = buskh.getKhachhang();
        }
        public void RefreshTest()
        {
            txtMaKh.Text = "";
            txtTenKh.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            txtTim.Text = "";
            makhsua = 0;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string timten = txtTim.Text;
            dgvKhachhang.DataSource = buskh.timkiemKh(timten);
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string themten = txtTenKh.Text;
            string themsdt = txtSDT.Text;
            string themdiachi = txtDiachi.Text;
            if (themten.Equals("")) { MessageBox.Show("Thiếu tên", "Thêm không thành công !"); }
            if (themsdt.Equals("")) { MessageBox.Show("Thiếu sdt", "Thêm không thành công !"); }
            if (themdiachi.Equals("")) { MessageBox.Show("Thiếu diachi", "Thêm không thành công !"); }
            if (!themten.Equals("") && !themsdt.Equals("") && !themdiachi.Equals(""))
            {
                if (buskh.themKhachhang(themten, themsdt, themdiachi))
                {
                    dgvKhachhang.DataSource = buskh.getKhachhang();
                    MessageBox.Show("Thêm thành công !", "Info");
                    RefreshTest();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công !", "Info");
                    RefreshTest();
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string suaten = txtTenKh.Text;
            string suasdt = txtSDT.Text;
            string suadiachi = txtDiachi.Text;
            if (suaten.Equals("")) { MessageBox.Show("Thiếu tên", "Sửa không thành công !"); }
            if (suasdt.Equals("")) { MessageBox.Show("Thiếu sdt", "Sửa không thành công !"); }
            if (suadiachi.Equals("")) { MessageBox.Show("Thiếu diachi", "Sửa không thành công !"); }
            if (!suaten.Equals("") && !suasdt.Equals("") && !suadiachi.Equals(""))
            {
                if (buskh.suaKhachhang(makhsua,suaten, suasdt, suadiachi))
                {
                    dgvKhachhang.DataSource = buskh.getKhachhang();
                    MessageBox.Show("Sửa thành công !", "Info");
                    RefreshTest();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công !", "Info");
                    RefreshTest();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshTest();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (!e.KeyChar.Equals(".")))
            {
                e.Handled = true;
            }
        }

        private void dgvKhachhang_Click(object sender, EventArgs e)
        {
            int i = dgvKhachhang.CurrentRow.Index;
            makhsua = int.Parse(dgvKhachhang[0, i].Value.ToString());
            txtMaKh.Text = makhsua.ToString();
            txtTenKh.Text = dgvKhachhang[1, i].Value.ToString();
            txtSDT.Text = dgvKhachhang[2, i].Value.ToString();
            txtDiachi.Text = dgvKhachhang[3, i].Value.ToString();

        }
    }
}
