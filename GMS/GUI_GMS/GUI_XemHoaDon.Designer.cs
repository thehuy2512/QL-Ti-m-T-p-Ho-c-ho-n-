
namespace GUI_GMS
{
    partial class GUI_XemHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvXemHD = new System.Windows.Forms.DataGridView();
            this.dgvXemcthd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemcthd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvXemcthd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(971, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 753);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hoá đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvXemHD);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 553);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hoá đơn";
            // 
            // dgvXemHD
            // 
            this.dgvXemHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mahd,
            this.makh,
            this.tenkh,
            this.ngaymua,
            this.trangthai,
            this.thanhtien});
            this.dgvXemHD.Location = new System.Drawing.Point(0, 21);
            this.dgvXemHD.Name = "dgvXemHD";
            this.dgvXemHD.RowHeadersWidth = 51;
            this.dgvXemHD.RowTemplate.Height = 24;
            this.dgvXemHD.Size = new System.Drawing.Size(928, 523);
            this.dgvXemHD.TabIndex = 0;
            this.dgvXemHD.Click += new System.EventHandler(this.dgvXemHD_Click);
            // 
            // dgvXemcthd
            // 
            this.dgvXemcthd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvXemcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemcthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.mahang,
            this.tenhang,
            this.soluongmua,
            this.gia,
            this.thanhtien1,
            this.mahd1});
            this.dgvXemcthd.Location = new System.Drawing.Point(20, 42);
            this.dgvXemcthd.Name = "dgvXemcthd";
            this.dgvXemcthd.RowHeadersWidth = 51;
            this.dgvXemcthd.RowTemplate.Height = 24;
            this.dgvXemcthd.Size = new System.Drawing.Size(624, 534);
            this.dgvXemcthd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách hàng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(720, 149);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 42);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(479, 621);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(129, 91);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận thanh toán";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "stt";
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã hoá đơn";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            this.mahd.Width = 75;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.Width = 80;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 200;
            // 
            // ngaymua
            // 
            this.ngaymua.DataPropertyName = "ngaymua";
            this.ngaymua.HeaderText = "Ngày mua";
            this.ngaymua.MinimumWidth = 6;
            this.ngaymua.Name = "ngaymua";
            this.ngaymua.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 125;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã hoá đơn:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(417, 152);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(297, 42);
            this.txtTimkiem.TabIndex = 5;
            // 
            // txtMahd
            // 
            this.txtMahd.Enabled = false;
            this.txtMahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahd.Location = new System.Drawing.Point(182, 51);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(216, 30);
            this.txtMahd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Enabled = false;
            this.txtTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.Location = new System.Drawing.Point(121, 621);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(216, 30);
            this.txtTongtien.TabIndex = 7;
            this.txtTongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Enabled = false;
            this.txtTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangthai.Location = new System.Drawing.Point(182, 113);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(216, 30);
            this.txtTrangthai.TabIndex = 7;
            // 
            // stt1
            // 
            this.stt1.DataPropertyName = "stt";
            this.stt1.HeaderText = "STT";
            this.stt1.MinimumWidth = 6;
            this.stt1.Name = "stt1";
            this.stt1.Width = 80;
            // 
            // mahang
            // 
            this.mahang.DataPropertyName = "mahang";
            this.mahang.HeaderText = "Mã hàng";
            this.mahang.MinimumWidth = 6;
            this.mahang.Name = "mahang";
            this.mahang.Width = 80;
            // 
            // tenhang
            // 
            this.tenhang.DataPropertyName = "tenhang";
            this.tenhang.HeaderText = "Tên hàng";
            this.tenhang.MinimumWidth = 6;
            this.tenhang.Name = "tenhang";
            this.tenhang.Width = 80;
            // 
            // soluongmua
            // 
            this.soluongmua.DataPropertyName = "soluongmua";
            this.soluongmua.HeaderText = "Số lượng mua";
            this.soluongmua.MinimumWidth = 6;
            this.soluongmua.Name = "soluongmua";
            this.soluongmua.Width = 81;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 80;
            // 
            // thanhtien1
            // 
            this.thanhtien1.DataPropertyName = "thanhtien";
            this.thanhtien1.HeaderText = "Thành tiền";
            this.thanhtien1.MinimumWidth = 6;
            this.thanhtien1.Name = "thanhtien1";
            this.thanhtien1.Width = 80;
            // 
            // mahd1
            // 
            this.mahd1.DataPropertyName = "mahd";
            this.mahd1.HeaderText = "Mã hoá đơn";
            this.mahd1.MinimumWidth = 6;
            this.mahd1.Name = "mahd1";
            this.mahd1.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "( VND)";
            // 
            // GUI_XemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1627, 753);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "GUI_XemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_XemHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemcthd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvXemcthd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvXemHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongmua;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd1;
        private System.Windows.Forms.Label label3;
    }
}