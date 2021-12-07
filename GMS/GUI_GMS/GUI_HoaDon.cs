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
    public partial class GUI_HoaDon : Form
    {
        int sothutu = 0;
        string tammahang;
        string tamtenhang;
        string tamdongia;
        int iddongxuly=-1;
        int idthemhd = -5;

        DataTable dtbKhachhang;
        DataTable dtbHanghoa;
        BUS_Hanghoa bushh = new BUS_Hanghoa();
        BUS_Khachhang buskh = new BUS_Khachhang();
        BUS_Hoadon bushd = new BUS_Hoadon();
        BUS_Chitiethoadon buscthd = new BUS_Chitiethoadon();
        public GUI_HoaDon()
        {
            InitializeComponent();
            dtbKhachhang = buskh.getKhachhang();
            dtbHanghoa = bushh.getHanghoaCon();
            loadKhachhang();
            loadHanghoa();
        }
        private void loadKhachhang()
        {
            for(int i = 0; i < dtbKhachhang.Rows.Count; i++)
            {
                cmbKhachhang.Items.Add(dtbKhachhang.Rows[i]["tenkh"].ToString());
                cmbKhachhang.Text = dtbKhachhang.Rows[0]["tenkh"].ToString();
            }
        }
        private void loadHanghoa()
        {
            for (int i = 0; i < dtbHanghoa.Rows.Count; i++)
            {
                cmbHanghoa.Items.Add(dtbHanghoa.Rows[i]["tenhang"].ToString());
                cmbHanghoa.Text = dtbHanghoa.Rows[0]["tenhang"].ToString();
            }
        }

        private void cmbHanghoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dongia = dtbHanghoa.Rows[int.Parse(cmbHanghoa.SelectedIndex.ToString())]["gia"].ToString();
            txtĐongia.Text = dongia;
            tammahang= dtbHanghoa.Rows[int.Parse(cmbHanghoa.SelectedIndex.ToString())]["mahang"].ToString();
            tamtenhang= dtbHanghoa.Rows[int.Parse(cmbHanghoa.SelectedIndex.ToString())]["tenhang"].ToString();
            tamdongia= dtbHanghoa.Rows[int.Parse(cmbHanghoa.SelectedIndex.ToString())]["gia"].ToString();
            txtSoluong.Text = "";
            txtSoluong.Focus();

        }

        private void cmbKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = dtbKhachhang.Rows[int.Parse(cmbKhachhang.SelectedIndex.ToString())]["makh"].ToString();
            txtMakh.Text = makh;
        }
        void Tinhtong()
        {
            long tongtien = 0;
            for (int i=0;i< dgvHanghoa.Rows.Count-1;i++)
            {
                
                 long tam1dongia = long.Parse(dgvHanghoa.Rows[i].Cells["dongia"].Value.ToString());
                 long tam1soluong = long.Parse(dgvHanghoa.Rows[i].Cells["soluong"].Value.ToString());

                 long tam1tongtien = tam1dongia * tam1soluong;
                 tongtien +=tam1tongtien;
            }
            txtTongtien.Text = tongtien.ToString();
        }
        private void btnThemhang_Click(object sender, EventArgs e)
        {
            
            if (!txtSoluong.Text.Equals(""))
            {
                sothutu++;
                string[] row = { sothutu.ToString(), tammahang, tamtenhang, tamdongia, txtSoluong.Text };
                dgvHanghoa.Rows.Add(row);
                Tinhtong();
            }
            else
            {
                MessageBox.Show("Số lượng không được để trống!", "Info");
                txtSoluong.Focus();
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (!e.KeyChar.Equals(".")))
            {
                e.Handled = true;
            }

        }
        private void dgvHanghoa_Click(object sender, EventArgs e)
        {
            iddongxuly = dgvHanghoa.CurrentRow.Index;
            cmbHanghoa.Text = dgvHanghoa.Rows[iddongxuly].Cells["tenhang"].Value.ToString();
            txtĐongia.Text = dgvHanghoa.Rows[iddongxuly].Cells["dongia"].Value.ToString();
            txtSoluong.Text = dgvHanghoa.Rows[iddongxuly].Cells["soluong"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (iddongxuly != -1)
            {
                dgvHanghoa.Rows[iddongxuly].Cells["soluong"].Value = txtSoluong.Text.ToString();
                MessageBox.Show("Sửa số lượng thành công", "Info");
                txtSoluong.Text = "";
                iddongxuly = -1;
                Tinhtong();
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng xử lý hoặc chưa có dữ liệu !", "Info");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (iddongxuly != -1)
            {
                dgvHanghoa.Rows.RemoveAt(iddongxuly);

               iddongxuly = -1;
               Tinhtong();
                // xử lý lại số thứ tự 
                int j = 0;
                for (int i = 0;i< dgvHanghoa.Rows.Count - 1; i++)
                {
                    j++;
                    dgvHanghoa.Rows[i].Cells["STT"].Value = j;
                }
                MessageBox.Show("Xoá hàng thành công", "Info");
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng xử lý hoặc chưa có dữ liệu !", "Info");
            }
        }

        private void btnLuuhd_Click(object sender, EventArgs e)
        {
            long themmakh = long.Parse(txtMakh.Text);
            long themthanhtien = long.Parse(txtTongtien.Text);
            idthemhd = bushd.themHD(themmakh,themthanhtien);
            //MessageBox.Show(idthemhd.ToString());
            // xem kq để kiểm tra
            if (idthemhd == -1)
            {
                MessageBox.Show("Thêm hd không thành", "Info");

            }
            if (idthemhd == -5)
            {
                MessageBox.Show("Chưa thực hiện thêm hoá đơn","Info");
            }
            if (idthemhd>=0)
            {
                for(int i=0; i < dgvHanghoa.Rows.Count-1;i++)
                {
                    string themmahang = dgvHanghoa.Rows[i].Cells["mahang"].Value.ToString();
                    long themsoluong = long.Parse(dgvHanghoa.Rows[i].Cells["soluong"].Value.ToString());
                    int themmahd = idthemhd;
                    bool check=buscthd.themCthd(themmahang, themsoluong, themmahd);
                    if (check == false)
                    {
                        
                        MessageBox.Show("Thêm chi tiết hoá đơn không thành công!", "Thêm hoá đơn thành công");
                        return;
                    }
                    
                }
                MessageBox.Show("Thêm chi tiết hoá đơn thành công!", "Info");
                //Close();
                // thay close bằng việc chuyển sang màn hình xem hoá đơn
                GUI_XemHoaDon frmxhd = new GUI_XemHoaDon();
                frmxhd.Show();
            }    
        }
    }
}
