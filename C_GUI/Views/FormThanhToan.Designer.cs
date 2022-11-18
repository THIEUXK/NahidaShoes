namespace C_GUI.Views
{
    partial class FormThanhToan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lsvGioHang = new System.Windows.Forms.ListView();
            this._Id = new System.Windows.Forms.ColumnHeader();
            this._TenGiay = new System.Windows.Forms.ColumnHeader();
            this._DonGia = new System.Windows.Forms.ColumnHeader();
            this._SoLuong = new System.Windows.Forms.ColumnHeader();
            this._tbxMaHoaDon = new C_GUI.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._tbxGiamGia = new C_GUI.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tbxMaNhanVien = new C_GUI.RJControls.RJTextBox();
            this._tbxMaKhachHang = new C_GUI.RJControls.RJTextBox();
            this._tbxGhiChu = new C_GUI.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._tbxTongTien = new C_GUI.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._tbxTienKhachDua = new C_GUI.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._btnThanhToan = new C_GUI.RJControls.RJButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._lsvGioHang);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(322, 428);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ Hàng";
            // 
            // _lsvGioHang
            // 
            this._lsvGioHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Id,
            this._TenGiay,
            this._DonGia,
            this._SoLuong});
            this._lsvGioHang.FullRowSelect = true;
            this._lsvGioHang.Location = new System.Drawing.Point(5, 20);
            this._lsvGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvGioHang.Name = "_lsvGioHang";
            this._lsvGioHang.Size = new System.Drawing.Size(317, 404);
            this._lsvGioHang.TabIndex = 0;
            this._lsvGioHang.UseCompatibleStateImageBehavior = false;
            this._lsvGioHang.View = System.Windows.Forms.View.Details;
            // 
            // _Id
            // 
            this._Id.Text = "Id";
            this._Id.Width = 0;
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
            // _tbxMaHoaDon
            // 
            this._tbxMaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMaHoaDon.BorderColor = System.Drawing.Color.Black;
            this._tbxMaHoaDon.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMaHoaDon.BorderRadius = 15;
            this._tbxMaHoaDon.BorderSize = 2;
            this._tbxMaHoaDon.Enabled = false;
            this._tbxMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMaHoaDon.Location = new System.Drawing.Point(494, 21);
            this._tbxMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMaHoaDon.MaxLength = 20;
            this._tbxMaHoaDon.Multiline = false;
            this._tbxMaHoaDon.Name = "_tbxMaHoaDon";
            this._tbxMaHoaDon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMaHoaDon.PasswordChar = false;
            this._tbxMaHoaDon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMaHoaDon.PlaceholderText = "";
            this._tbxMaHoaDon.Size = new System.Drawing.Size(201, 31);
            this._tbxMaHoaDon.TabIndex = 26;
            this._tbxMaHoaDon.Texts = "";
            this._tbxMaHoaDon.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(340, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(340, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(340, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // _tbxGiamGia
            // 
            this._tbxGiamGia.BackColor = System.Drawing.SystemColors.Window;
            this._tbxGiamGia.BorderColor = System.Drawing.Color.Black;
            this._tbxGiamGia.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxGiamGia.BorderRadius = 15;
            this._tbxGiamGia.BorderSize = 2;
            this._tbxGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxGiamGia.Location = new System.Drawing.Point(494, 138);
            this._tbxGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this._tbxGiamGia.MaxLength = 20;
            this._tbxGiamGia.Multiline = false;
            this._tbxGiamGia.Name = "_tbxGiamGia";
            this._tbxGiamGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxGiamGia.PasswordChar = false;
            this._tbxGiamGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxGiamGia.PlaceholderText = "";
            this._tbxGiamGia.Size = new System.Drawing.Size(201, 31);
            this._tbxGiamGia.TabIndex = 30;
            this._tbxGiamGia.Texts = "0";
            this._tbxGiamGia.UnderlinedStyle = false;
            this._tbxGiamGia._TextChanged += new System.EventHandler(this._tbxGiamGia__TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(340, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Giảm giá";
            // 
            // _tbxMaNhanVien
            // 
            this._tbxMaNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMaNhanVien.BorderColor = System.Drawing.Color.Black;
            this._tbxMaNhanVien.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMaNhanVien.BorderRadius = 15;
            this._tbxMaNhanVien.BorderSize = 2;
            this._tbxMaNhanVien.Enabled = false;
            this._tbxMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMaNhanVien.Location = new System.Drawing.Point(494, 99);
            this._tbxMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMaNhanVien.MaxLength = 20;
            this._tbxMaNhanVien.Multiline = false;
            this._tbxMaNhanVien.Name = "_tbxMaNhanVien";
            this._tbxMaNhanVien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMaNhanVien.PasswordChar = false;
            this._tbxMaNhanVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMaNhanVien.PlaceholderText = "";
            this._tbxMaNhanVien.Size = new System.Drawing.Size(201, 31);
            this._tbxMaNhanVien.TabIndex = 31;
            this._tbxMaNhanVien.Texts = "";
            this._tbxMaNhanVien.UnderlinedStyle = false;
            // 
            // _tbxMaKhachHang
            // 
            this._tbxMaKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMaKhachHang.BorderColor = System.Drawing.Color.Black;
            this._tbxMaKhachHang.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMaKhachHang.BorderRadius = 15;
            this._tbxMaKhachHang.BorderSize = 2;
            this._tbxMaKhachHang.Enabled = false;
            this._tbxMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMaKhachHang.Location = new System.Drawing.Point(494, 60);
            this._tbxMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMaKhachHang.MaxLength = 20;
            this._tbxMaKhachHang.Multiline = false;
            this._tbxMaKhachHang.Name = "_tbxMaKhachHang";
            this._tbxMaKhachHang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMaKhachHang.PasswordChar = false;
            this._tbxMaKhachHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMaKhachHang.PlaceholderText = "";
            this._tbxMaKhachHang.Size = new System.Drawing.Size(201, 31);
            this._tbxMaKhachHang.TabIndex = 32;
            this._tbxMaKhachHang.Texts = "";
            this._tbxMaKhachHang.UnderlinedStyle = false;
            // 
            // _tbxGhiChu
            // 
            this._tbxGhiChu.BackColor = System.Drawing.SystemColors.Window;
            this._tbxGhiChu.BorderColor = System.Drawing.Color.Black;
            this._tbxGhiChu.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxGhiChu.BorderRadius = 15;
            this._tbxGhiChu.BorderSize = 2;
            this._tbxGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxGhiChu.Location = new System.Drawing.Point(494, 177);
            this._tbxGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this._tbxGhiChu.MaxLength = 20;
            this._tbxGhiChu.Multiline = true;
            this._tbxGhiChu.Name = "_tbxGhiChu";
            this._tbxGhiChu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxGhiChu.PasswordChar = false;
            this._tbxGhiChu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxGhiChu.PlaceholderText = "";
            this._tbxGhiChu.Size = new System.Drawing.Size(201, 145);
            this._tbxGhiChu.TabIndex = 34;
            this._tbxGhiChu.Texts = "";
            this._tbxGhiChu.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(340, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ghi chú";
            // 
            // _tbxTongTien
            // 
            this._tbxTongTien.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTongTien.BorderColor = System.Drawing.Color.Black;
            this._tbxTongTien.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTongTien.BorderRadius = 15;
            this._tbxTongTien.BorderSize = 2;
            this._tbxTongTien.Enabled = false;
            this._tbxTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTongTien.Location = new System.Drawing.Point(494, 330);
            this._tbxTongTien.Margin = new System.Windows.Forms.Padding(4);
            this._tbxTongTien.MaxLength = 20;
            this._tbxTongTien.Multiline = false;
            this._tbxTongTien.Name = "_tbxTongTien";
            this._tbxTongTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxTongTien.PasswordChar = false;
            this._tbxTongTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTongTien.PlaceholderText = "";
            this._tbxTongTien.Size = new System.Drawing.Size(201, 31);
            this._tbxTongTien.TabIndex = 36;
            this._tbxTongTien.Texts = "";
            this._tbxTongTien.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(340, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tổng tiền";
            // 
            // _tbxTienKhachDua
            // 
            this._tbxTienKhachDua.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTienKhachDua.BorderColor = System.Drawing.Color.Black;
            this._tbxTienKhachDua.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTienKhachDua.BorderRadius = 15;
            this._tbxTienKhachDua.BorderSize = 2;
            this._tbxTienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTienKhachDua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTienKhachDua.Location = new System.Drawing.Point(494, 369);
            this._tbxTienKhachDua.Margin = new System.Windows.Forms.Padding(4);
            this._tbxTienKhachDua.MaxLength = 20;
            this._tbxTienKhachDua.Multiline = false;
            this._tbxTienKhachDua.Name = "_tbxTienKhachDua";
            this._tbxTienKhachDua.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxTienKhachDua.PasswordChar = false;
            this._tbxTienKhachDua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTienKhachDua.PlaceholderText = "";
            this._tbxTienKhachDua.Size = new System.Drawing.Size(201, 31);
            this._tbxTienKhachDua.TabIndex = 38;
            this._tbxTienKhachDua.Texts = "0";
            this._tbxTienKhachDua.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(340, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tiền khách đưa";
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
            this._btnThanhToan.Location = new System.Drawing.Point(345, 406);
            this._btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnThanhToan.Name = "_btnThanhToan";
            this._btnThanhToan.Size = new System.Drawing.Size(350, 29);
            this._btnThanhToan.SizeImage = new System.Drawing.Size(20, 20);
            this._btnThanhToan.TabIndex = 40;
            this._btnThanhToan.Text = "Thanh Toán";
            this._btnThanhToan.TextColor = System.Drawing.Color.Black;
            this._btnThanhToan.UseVisualStyleBackColor = false;
            this._btnThanhToan.Click += new System.EventHandler(this._btnThanhToan_Click);
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this._btnThanhToan);
            this.Controls.Add(this._tbxTienKhachDua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._tbxTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._tbxGhiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._tbxMaKhachHang);
            this.Controls.Add(this._tbxMaNhanVien);
            this.Controls.Add(this._tbxGiamGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._tbxMaHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormThanhToan";
            this.Text = "FormThanhToan";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private ListView _lsvGioHang;
        private ColumnHeader _Id;
        private ColumnHeader _TenGiay;
        private ColumnHeader _DonGia;
        private ColumnHeader _SoLuong;
        private RJControls.RJTextBox _tbxMaHoaDon;
        private Label label3;
        private Label label2;
        private Label label1;
        private RJControls.RJTextBox _tbxGiamGia;
        private Label label4;
        private RJControls.RJTextBox _tbxMaNhanVien;
        private RJControls.RJTextBox _tbxMaKhachHang;
        private RJControls.RJTextBox _tbxGhiChu;
        private Label label5;
        private RJControls.RJTextBox _tbxTongTien;
        private Label label6;
        private RJControls.RJTextBox _tbxTienKhachDua;
        private Label label7;
        private RJControls.RJButton _btnThanhToan;
    }
}