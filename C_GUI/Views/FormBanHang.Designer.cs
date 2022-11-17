namespace C_GUI.Views
{
    partial class FormBanHang
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lsvShowSanPham = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.TenGiay = new System.Windows.Forms.ColumnHeader();
            this.MauSac = new System.Windows.Forms.ColumnHeader();
            this.HangGiay = new System.Windows.Forms.ColumnHeader();
            this.Nsx = new System.Windows.Forms.ColumnHeader();
            this.Size = new System.Windows.Forms.ColumnHeader();
            this.ChieuCaoDeGiay = new System.Windows.Forms.ColumnHeader();
            this.GiaBan = new System.Windows.Forms.ColumnHeader();
            this.SoLuongTon = new System.Windows.Forms.ColumnHeader();
            this.MoTa = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lsvShowHoaDon = new System.Windows.Forms.ListView();
            this._Id = new System.Windows.Forms.ColumnHeader();
            this._MaHoaDon = new System.Windows.Forms.ColumnHeader();
            this._TenGiay = new System.Windows.Forms.ColumnHeader();
            this._DonGia = new System.Windows.Forms.ColumnHeader();
            this._SoLuong = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbxNhanVien = new C_GUI.RJControls.RJComboBox();
            this._cbxKhachHang = new C_GUI.RJControls.RJComboBox();
            this._tbxMaHoaDon = new C_GUI.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._btnTaoHoaDon = new C_GUI.RJControls.RJButton();
            this._btnThanhToan = new C_GUI.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lsvShowSanPham);
            this.groupBox1.Location = new System.Drawing.Point(375, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(973, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // _lsvShowSanPham
            // 
            this._lsvShowSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.TenGiay,
            this.MauSac,
            this.HangGiay,
            this.Nsx,
            this.Size,
            this.ChieuCaoDeGiay,
            this.GiaBan,
            this.SoLuongTon,
            this.MoTa});
            this._lsvShowSanPham.FullRowSelect = true;
            this._lsvShowSanPham.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this._lsvShowSanPham.Location = new System.Drawing.Point(5, 20);
            this._lsvShowSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvShowSanPham.Name = "_lsvShowSanPham";
            this._lsvShowSanPham.Size = new System.Drawing.Size(969, 184);
            this._lsvShowSanPham.TabIndex = 1;
            this._lsvShowSanPham.UseCompatibleStateImageBehavior = false;
            this._lsvShowSanPham.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // TenGiay
            // 
            this.TenGiay.Text = "Tên Giày";
            this.TenGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenGiay.Width = 100;
            // 
            // MauSac
            // 
            this.MauSac.Text = "Màu Sắc";
            this.MauSac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MauSac.Width = 100;
            // 
            // HangGiay
            // 
            this.HangGiay.Text = "Hãng Giày";
            this.HangGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HangGiay.Width = 100;
            // 
            // Nsx
            // 
            this.Nsx.Text = "Nsx";
            this.Nsx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nsx.Width = 100;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Size.Width = 100;
            // 
            // ChieuCaoDeGiay
            // 
            this.ChieuCaoDeGiay.Text = "Chiều Cao Đế Giày";
            this.ChieuCaoDeGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChieuCaoDeGiay.Width = 150;
            // 
            // GiaBan
            // 
            this.GiaBan.Text = "Giá Bán";
            this.GiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaBan.Width = 100;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.Text = "Số Lượng Tồn";
            this.SoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuongTon.Width = 100;
            // 
            // MoTa
            // 
            this.MoTa.Text = "Mô Tả";
            this.MoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoTa.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._lsvShowHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(1, 243);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(485, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ Hàng";
            // 
            // _lsvShowHoaDon
            // 
            this._lsvShowHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Id,
            this._MaHoaDon,
            this._TenGiay,
            this._DonGia,
            this._SoLuong});
            this._lsvShowHoaDon.FullRowSelect = true;
            this._lsvShowHoaDon.Location = new System.Drawing.Point(5, 20);
            this._lsvShowHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvShowHoaDon.Name = "_lsvShowHoaDon";
            this._lsvShowHoaDon.Size = new System.Drawing.Size(478, 194);
            this._lsvShowHoaDon.TabIndex = 0;
            this._lsvShowHoaDon.UseCompatibleStateImageBehavior = false;
            this._lsvShowHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // _Id
            // 
            this._Id.Text = "Id";
            // 
            // _MaHoaDon
            // 
            this._MaHoaDon.Text = "Mã Hóa Đơn";
            this._MaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._MaHoaDon.Width = 100;
            // 
            // _TenGiay
            // 
            this._TenGiay.Text = "Tên Giày ";
            this._TenGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._TenGiay.Width = 100;
            // 
            // _DonGia
            // 
            this._DonGia.Text = "Đơn Giá";
            this._DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._DonGia.Width = 100;
            // 
            // _SoLuong
            // 
            this._SoLuong.Text = "Số Lượng";
            this._SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._SoLuong.Width = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._cbxNhanVien);
            this.groupBox3.Controls.Add(this._cbxKhachHang);
            this.groupBox3.Controls.Add(this._tbxMaHoaDon);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this._btnTaoHoaDon);
            this.groupBox3.Controls.Add(this._btnThanhToan);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(10, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(359, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin";
            // 
            // _cbxNhanVien
            // 
            this._cbxNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNhanVien.BorderSize = 1;
            this._cbxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this._cbxNhanVien.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNhanVien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxNhanVien.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxNhanVien.Location = new System.Drawing.Point(154, 101);
            this._cbxNhanVien.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxNhanVien.Name = "_cbxNhanVien";
            this._cbxNhanVien.Padding = new System.Windows.Forms.Padding(1);
            this._cbxNhanVien.Size = new System.Drawing.Size(201, 30);
            this._cbxNhanVien.TabIndex = 22;
            this._cbxNhanVien.Texts = "";
            // 
            // _cbxKhachHang
            // 
            this._cbxKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxKhachHang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxKhachHang.BorderSize = 1;
            this._cbxKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxKhachHang.ForeColor = System.Drawing.Color.DimGray;
            this._cbxKhachHang.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxKhachHang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxKhachHang.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxKhachHang.Location = new System.Drawing.Point(155, 65);
            this._cbxKhachHang.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxKhachHang.Name = "_cbxKhachHang";
            this._cbxKhachHang.Padding = new System.Windows.Forms.Padding(1);
            this._cbxKhachHang.Size = new System.Drawing.Size(200, 30);
            this._cbxKhachHang.TabIndex = 21;
            this._cbxKhachHang.Texts = "";
            // 
            // _tbxMaHoaDon
            // 
            this._tbxMaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMaHoaDon.BorderColor = System.Drawing.Color.Black;
            this._tbxMaHoaDon.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMaHoaDon.BorderRadius = 15;
            this._tbxMaHoaDon.BorderSize = 2;
            this._tbxMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMaHoaDon.Location = new System.Drawing.Point(154, 27);
            this._tbxMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMaHoaDon.MaxLength = 20;
            this._tbxMaHoaDon.Multiline = false;
            this._tbxMaHoaDon.Name = "_tbxMaHoaDon";
            this._tbxMaHoaDon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMaHoaDon.PasswordChar = false;
            this._tbxMaHoaDon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMaHoaDon.PlaceholderText = "";
            this._tbxMaHoaDon.Size = new System.Drawing.Size(201, 31);
            this._tbxMaHoaDon.TabIndex = 20;
            this._tbxMaHoaDon.Texts = "";
            this._tbxMaHoaDon.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // _btnTaoHoaDon
            // 
            this._btnTaoHoaDon.BackColor = System.Drawing.Color.Turquoise;
            this._btnTaoHoaDon.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnTaoHoaDon.BorderColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.BorderRadius = 15;
            this._btnTaoHoaDon.BorderSize = 2;
            this._btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            this._btnTaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnTaoHoaDon.ForeColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.Location = new System.Drawing.Point(2, 136);
            this._btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnTaoHoaDon.Name = "_btnTaoHoaDon";
            this._btnTaoHoaDon.Size = new System.Drawing.Size(351, 29);
            this._btnTaoHoaDon.SizeImage = new System.Drawing.Size(20, 20);
            this._btnTaoHoaDon.TabIndex = 16;
            this._btnTaoHoaDon.Text = "Tạo Hóa Đơn";
            this._btnTaoHoaDon.TextColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.UseVisualStyleBackColor = false;
            this._btnTaoHoaDon.Click += new System.EventHandler(this._btnTaoHoaDon_Click);
            // 
            // _btnThanhToan
            // 
            this._btnThanhToan.BackColor = System.Drawing.Color.Turquoise;
            this._btnThanhToan.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnThanhToan.BorderColor = System.Drawing.Color.Black;
            this._btnThanhToan.BorderRadius = 15;
            this._btnThanhToan.BorderSize = 2;
            this._btnThanhToan.FlatAppearance.BorderSize = 0;
            this._btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this._btnThanhToan.Location = new System.Drawing.Point(2, 169);
            this._btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnThanhToan.Name = "_btnThanhToan";
            this._btnThanhToan.Size = new System.Drawing.Size(351, 29);
            this._btnThanhToan.SizeImage = new System.Drawing.Size(20, 20);
            this._btnThanhToan.TabIndex = 15;
            this._btnThanhToan.Text = "Thanh Toán";
            this._btnThanhToan.TextColor = System.Drawing.Color.Black;
            this._btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(492, 243);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(857, 214);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa Đơn Chờ";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 468);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private RJControls.RJButton _btnThanhToan;
        private GroupBox groupBox4;
        private ListView _lsvShowSanPham;
        private ColumnHeader Id;
        private ColumnHeader TenGiay;
        private ColumnHeader MauSac;
        private RJControls.RJButton _btnTaoHoaDon;
        private ColumnHeader HangGiay;
        private ColumnHeader Nsx;
        private ColumnHeader Size;
        private ColumnHeader ChieuCaoDeGiay;
        private ColumnHeader GiaBan;
        private ColumnHeader SoLuongTon;
        private ColumnHeader MoTa;
        private ListView _lsvShowHoaDon;
        private Label label3;
        private ColumnHeader _Id;
        private ColumnHeader _MaHoaDon;
        private ColumnHeader _TenGiay;
        private ColumnHeader _DonGia;
        private ColumnHeader _SoLuong;
        private RJControls.RJComboBox _cbxNhanVien;
        private RJControls.RJComboBox _cbxKhachHang;
        private RJControls.RJTextBox _tbxMaHoaDon;
    }
}