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
    public partial class GUI_Hanghoa : Form
    {
        BUS_Hanghoa bushh = new BUS_Hanghoa();
        // string mahangsua;
        string mahangsua;
        bool trangthaihang=true;
        public GUI_Hanghoa()
        {
            InitializeComponent();
            LoadTableHh();
        }
        void LoadTableHh()
        {
            dgvHanghoa.DataSource = bushh.getHanghoa();
        }
        void RefreshTest()
        {
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtLoaihang.Text = "";
            txtSoluong.Text = "";
            txtGia.Text = "";
            txtTim.Text = "";
            mahangsua = null;
            trangthaihang = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string themmahang = txtMahang.Text;
            string themtenhang = txtTenhang.Text;
            string themloaihang = txtLoaihang.Text;
            string themsoluong = txtSoluong.Text;
            string themgia = txtGia.Text;
            // check mã hàng không được trùng
            if (bushh.ktMahang(themmahang) == true)
            {
                MessageBox.Show("Mã hàng đã tồn tại", "Info");
                txtMahang.Focus();
            }
            else
            {
                if (themmahang.Equals("")) { MessageBox.Show("Thiếu mã hàng", "Thêm không thành công !"); }
                if (themtenhang.Equals("")) { MessageBox.Show("Thiếu tên hàng", "Thêm không thành công !"); }
                if (themloaihang.Equals("")) { MessageBox.Show("Thiếu loại hàng", "Thêm không thành công !"); }
                if (themsoluong.Equals("")) { MessageBox.Show("Thiếu số lượng", "Thêm không thành công !"); }
                if (themgia.Equals("")) { MessageBox.Show("Thiếu giá", "Thêm không thành công !"); }
                if(!themmahang.Equals("") && !themtenhang.Equals("") && !themloaihang.Equals("")&& !themsoluong.Equals("") && !themgia.Equals(""))
                {
                    if (bushh.themHanghoa(themmahang,themtenhang,themloaihang,long.Parse(themsoluong),long.Parse(themgia)))
                    {
                        dgvHanghoa.DataSource = bushh.getHanghoa();
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string suatenhang = txtTenhang.Text;
            string sualoaihang = txtLoaihang.Text;
            string suasoluong = txtSoluong.Text;
            string suagia = txtGia.Text;
            
                
                if (suatenhang.Equals("")) { MessageBox.Show("Thiếu tên hàng", "Sửa không thành công !"); }
                if (sualoaihang.Equals("")) { MessageBox.Show("Thiếu loại hàng", "Sửa không thành công !"); }
                if (suasoluong.Equals("")) { MessageBox.Show("Thiếu số lượng", "Sửa không thành công !"); }
                if (suagia.Equals("")) { MessageBox.Show("Thiếu giá", "Sửa không thành công !"); }
                if (!suatenhang.Equals("") && !sualoaihang.Equals("") && !suasoluong.Equals("") && !suagia.Equals(""))
                {
                   if (bushh.suaHanghoa(mahangsua, suatenhang, sualoaihang, long.Parse(suasoluong), long.Parse(suagia)))
                    {
                        dgvHanghoa.DataSource = bushh.getHanghoa();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshTest();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if(bushh.capnhattrangthaiHanghoa(trangthaihang,mahangsua))
            {
                dgvHanghoa.DataSource = bushh.getHanghoa();
                MessageBox.Show("Cập nhật trạng thái thành công !", "Info");
                RefreshTest();
            }
            else {
                MessageBox.Show("Cập nhật trạng thái không thành công !", "Info");
                RefreshTest();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenhangtim = txtTim.Text;
            dgvHanghoa.DataSource = bushh.timkiemHh(tenhangtim);
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (!e.KeyChar.Equals(".")))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (!e.KeyChar.Equals(".")))
            {
                e.Handled = true;
            }
        }

        private void dgvHanghoa_Click(object sender, EventArgs e)
        {
            int i = dgvHanghoa.CurrentRow.Index;
            mahangsua = dgvHanghoa[0, i].Value.ToString();
            txtMahang.Text = dgvHanghoa[0, i].Value.ToString();
            txtTenhang.Text = dgvHanghoa[1, i].Value.ToString();
            txtLoaihang.Text = dgvHanghoa[2, i].Value.ToString();
            txtSoluong.Text = dgvHanghoa[3, i].Value.ToString();
            txtGia.Text = dgvHanghoa[4, i].Value.ToString();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            trangthaihang = true;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            trangthaihang = false;
        }
    }
}
