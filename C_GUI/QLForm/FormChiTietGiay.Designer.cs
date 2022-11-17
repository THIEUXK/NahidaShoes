namespace C_GUI.QLForm
{
    partial class FormChiTietGiay
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
            this._lsvData = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.MauSac = new System.Windows.Forms.ColumnHeader();
            this.Nsx = new System.Windows.Forms.ColumnHeader();
            this.Size = new System.Windows.Forms.ColumnHeader();
            this.HangGiay = new System.Windows.Forms.ColumnHeader();
            this.ChieuCaoDeGiay = new System.Windows.Forms.ColumnHeader();
            this.Giay = new System.Windows.Forms.ColumnHeader();
            this.MoTa = new System.Windows.Forms.ColumnHeader();
            this.GiaNhap = new System.Windows.Forms.ColumnHeader();
            this.GiaBan = new System.Windows.Forms.ColumnHeader();
            this.SoLuongTon = new System.Windows.Forms.ColumnHeader();
            this.TrangThai = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this._cbxMauSac = new C_GUI.RJControls.RJComboBox();
            this._cbxHangGiay = new C_GUI.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cbxSize = new C_GUI.RJControls.RJComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cbxNsx = new C_GUI.RJControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._cbxChieuCaoDeGiay = new C_GUI.RJControls.RJComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._cbxGiay = new C_GUI.RJControls.RJComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._tbxMoTa = new C_GUI.RJControls.RJTextBox();
            this._tbxGiaNhap = new C_GUI.RJControls.RJTextBox();
            this._tbxGiaBan = new C_GUI.RJControls.RJTextBox();
            this._tbxSoLuongTon = new C_GUI.RJControls.RJTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._btnThem = new C_GUI.RJControls.RJButton();
            this._btnSua = new C_GUI.RJControls.RJButton();
            this._btnXoa = new C_GUI.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // _lsvData
            // 
            this._lsvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.MauSac,
            this.Nsx,
            this.Size,
            this.HangGiay,
            this.ChieuCaoDeGiay,
            this.Giay,
            this.MoTa,
            this.GiaNhap,
            this.GiaBan,
            this.SoLuongTon,
            this.TrangThai});
            this._lsvData.FullRowSelect = true;
            this._lsvData.Location = new System.Drawing.Point(12, 12);
            this._lsvData.MultiSelect = false;
            this._lsvData.Name = "_lsvData";
            this._lsvData.Size = new System.Drawing.Size(1215, 186);
            this._lsvData.TabIndex = 0;
            this._lsvData.UseCompatibleStateImageBehavior = false;
            this._lsvData.View = System.Windows.Forms.View.Details;
            this._lsvData.SelectedIndexChanged += new System.EventHandler(this._lsvData_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // MauSac
            // 
            this.MauSac.Text = "Màu sắc";
            this.MauSac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MauSac.Width = 100;
            // 
            // Nsx
            // 
            this.Nsx.Text = "Nhà sản xuất";
            this.Nsx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nsx.Width = 100;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Size.Width = 100;
            // 
            // HangGiay
            // 
            this.HangGiay.Text = "HangGiay";
            this.HangGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HangGiay.Width = 100;
            // 
            // ChieuCaoDeGiay
            // 
            this.ChieuCaoDeGiay.Text = "ChieuCaoDeGiay";
            this.ChieuCaoDeGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChieuCaoDeGiay.Width = 150;
            // 
            // Giay
            // 
            this.Giay.Text = "Giày";
            this.Giay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Giay.Width = 100;
            // 
            // MoTa
            // 
            this.MoTa.Text = "Mô tả";
            this.MoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoTa.Width = 100;
            // 
            // GiaNhap
            // 
            this.GiaNhap.Text = "Giá nhập";
            this.GiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaNhap.Width = 100;
            // 
            // GiaBan
            // 
            this.GiaBan.Text = "Giá bán";
            this.GiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaBan.Width = 100;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.Text = "Số lượng tồn";
            this.SoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuongTon.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng thái";
            this.TrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TrangThai.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Màu sắc";
            // 
            // _cbxMauSac
            // 
            this._cbxMauSac.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxMauSac.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxMauSac.BorderSize = 1;
            this._cbxMauSac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxMauSac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxMauSac.ForeColor = System.Drawing.Color.DimGray;
            this._cbxMauSac.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxMauSac.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxMauSac.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxMauSac.Location = new System.Drawing.Point(122, 204);
            this._cbxMauSac.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxMauSac.Name = "_cbxMauSac";
            this._cbxMauSac.Padding = new System.Windows.Forms.Padding(1);
            this._cbxMauSac.Size = new System.Drawing.Size(200, 30);
            this._cbxMauSac.TabIndex = 2;
            this._cbxMauSac.Texts = "";
            // 
            // _cbxHangGiay
            // 
            this._cbxHangGiay.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxHangGiay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxHangGiay.BorderSize = 1;
            this._cbxHangGiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxHangGiay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxHangGiay.ForeColor = System.Drawing.Color.DimGray;
            this._cbxHangGiay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxHangGiay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxHangGiay.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxHangGiay.Location = new System.Drawing.Point(122, 312);
            this._cbxHangGiay.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxHangGiay.Name = "_cbxHangGiay";
            this._cbxHangGiay.Padding = new System.Windows.Forms.Padding(1);
            this._cbxHangGiay.Size = new System.Drawing.Size(200, 30);
            this._cbxHangGiay.TabIndex = 4;
            this._cbxHangGiay.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hãng giày";
            // 
            // _cbxSize
            // 
            this._cbxSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxSize.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxSize.BorderSize = 1;
            this._cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxSize.ForeColor = System.Drawing.Color.DimGray;
            this._cbxSize.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxSize.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxSize.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxSize.Location = new System.Drawing.Point(122, 276);
            this._cbxSize.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxSize.Name = "_cbxSize";
            this._cbxSize.Padding = new System.Windows.Forms.Padding(1);
            this._cbxSize.Size = new System.Drawing.Size(200, 30);
            this._cbxSize.TabIndex = 6;
            this._cbxSize.Texts = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Size";
            // 
            // _cbxNsx
            // 
            this._cbxNsx.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxNsx.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNsx.BorderSize = 1;
            this._cbxNsx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxNsx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxNsx.ForeColor = System.Drawing.Color.DimGray;
            this._cbxNsx.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNsx.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxNsx.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxNsx.Location = new System.Drawing.Point(122, 240);
            this._cbxNsx.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxNsx.Name = "_cbxNsx";
            this._cbxNsx.Padding = new System.Windows.Forms.Padding(1);
            this._cbxNsx.Size = new System.Drawing.Size(200, 30);
            this._cbxNsx.TabIndex = 8;
            this._cbxNsx.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhà sản xuất";
            // 
            // _cbxChieuCaoDeGiay
            // 
            this._cbxChieuCaoDeGiay.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxChieuCaoDeGiay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxChieuCaoDeGiay.BorderSize = 1;
            this._cbxChieuCaoDeGiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxChieuCaoDeGiay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxChieuCaoDeGiay.ForeColor = System.Drawing.Color.DimGray;
            this._cbxChieuCaoDeGiay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxChieuCaoDeGiay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxChieuCaoDeGiay.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxChieuCaoDeGiay.Location = new System.Drawing.Point(122, 348);
            this._cbxChieuCaoDeGiay.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxChieuCaoDeGiay.Name = "_cbxChieuCaoDeGiay";
            this._cbxChieuCaoDeGiay.Padding = new System.Windows.Forms.Padding(1);
            this._cbxChieuCaoDeGiay.Size = new System.Drawing.Size(200, 30);
            this._cbxChieuCaoDeGiay.TabIndex = 10;
            this._cbxChieuCaoDeGiay.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chiều cao đế giày";
            // 
            // _cbxGiay
            // 
            this._cbxGiay.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxGiay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxGiay.BorderSize = 1;
            this._cbxGiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxGiay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxGiay.ForeColor = System.Drawing.Color.DimGray;
            this._cbxGiay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxGiay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxGiay.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxGiay.Location = new System.Drawing.Point(122, 384);
            this._cbxGiay.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxGiay.Name = "_cbxGiay";
            this._cbxGiay.Padding = new System.Windows.Forms.Padding(1);
            this._cbxGiay.Size = new System.Drawing.Size(200, 30);
            this._cbxGiay.TabIndex = 12;
            this._cbxGiay.Texts = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giá nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giá bán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mô tả";
            // 
            // _tbxMoTa
            // 
            this._tbxMoTa.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMoTa.BorderColor = System.Drawing.Color.Black;
            this._tbxMoTa.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMoTa.BorderRadius = 15;
            this._tbxMoTa.BorderSize = 2;
            this._tbxMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMoTa.Location = new System.Drawing.Point(408, 203);
            this._tbxMoTa.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMoTa.MaxLength = 20;
            this._tbxMoTa.Multiline = false;
            this._tbxMoTa.Name = "_tbxMoTa";
            this._tbxMoTa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMoTa.PasswordChar = false;
            this._tbxMoTa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMoTa.PlaceholderText = "";
            this._tbxMoTa.Size = new System.Drawing.Size(250, 31);
            this._tbxMoTa.TabIndex = 18;
            this._tbxMoTa.Texts = "";
            this._tbxMoTa.UnderlinedStyle = false;
            // 
            // _tbxGiaNhap
            // 
            this._tbxGiaNhap.BackColor = System.Drawing.SystemColors.Window;
            this._tbxGiaNhap.BorderColor = System.Drawing.Color.Black;
            this._tbxGiaNhap.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxGiaNhap.BorderRadius = 15;
            this._tbxGiaNhap.BorderSize = 2;
            this._tbxGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxGiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxGiaNhap.Location = new System.Drawing.Point(408, 239);
            this._tbxGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this._tbxGiaNhap.MaxLength = 20;
            this._tbxGiaNhap.Multiline = false;
            this._tbxGiaNhap.Name = "_tbxGiaNhap";
            this._tbxGiaNhap.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxGiaNhap.PasswordChar = false;
            this._tbxGiaNhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxGiaNhap.PlaceholderText = "";
            this._tbxGiaNhap.Size = new System.Drawing.Size(250, 31);
            this._tbxGiaNhap.TabIndex = 19;
            this._tbxGiaNhap.Texts = "";
            this._tbxGiaNhap.UnderlinedStyle = false;
            // 
            // _tbxGiaBan
            // 
            this._tbxGiaBan.BackColor = System.Drawing.SystemColors.Window;
            this._tbxGiaBan.BorderColor = System.Drawing.Color.Black;
            this._tbxGiaBan.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxGiaBan.BorderRadius = 15;
            this._tbxGiaBan.BorderSize = 2;
            this._tbxGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxGiaBan.Location = new System.Drawing.Point(408, 275);
            this._tbxGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this._tbxGiaBan.MaxLength = 20;
            this._tbxGiaBan.Multiline = false;
            this._tbxGiaBan.Name = "_tbxGiaBan";
            this._tbxGiaBan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxGiaBan.PasswordChar = false;
            this._tbxGiaBan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxGiaBan.PlaceholderText = "";
            this._tbxGiaBan.Size = new System.Drawing.Size(250, 31);
            this._tbxGiaBan.TabIndex = 20;
            this._tbxGiaBan.Texts = "";
            this._tbxGiaBan.UnderlinedStyle = false;
            // 
            // _tbxSoLuongTon
            // 
            this._tbxSoLuongTon.BackColor = System.Drawing.SystemColors.Window;
            this._tbxSoLuongTon.BorderColor = System.Drawing.Color.Black;
            this._tbxSoLuongTon.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxSoLuongTon.BorderRadius = 15;
            this._tbxSoLuongTon.BorderSize = 2;
            this._tbxSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxSoLuongTon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxSoLuongTon.Location = new System.Drawing.Point(408, 311);
            this._tbxSoLuongTon.Margin = new System.Windows.Forms.Padding(4);
            this._tbxSoLuongTon.MaxLength = 20;
            this._tbxSoLuongTon.Multiline = false;
            this._tbxSoLuongTon.Name = "_tbxSoLuongTon";
            this._tbxSoLuongTon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxSoLuongTon.PasswordChar = false;
            this._tbxSoLuongTon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxSoLuongTon.PlaceholderText = "";
            this._tbxSoLuongTon.Size = new System.Drawing.Size(250, 31);
            this._tbxSoLuongTon.TabIndex = 21;
            this._tbxSoLuongTon.Texts = "";
            this._tbxSoLuongTon.UnderlinedStyle = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Số lượng tồn";
            // 
            // _btnThem
            // 
            this._btnThem.BackColor = System.Drawing.Color.Turquoise;
            this._btnThem.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnThem.BorderColor = System.Drawing.Color.Black;
            this._btnThem.BorderRadius = 15;
            this._btnThem.BorderSize = 2;
            this._btnThem.FlatAppearance.BorderSize = 0;
            this._btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnThem.ForeColor = System.Drawing.Color.Black;
            this._btnThem.Location = new System.Drawing.Point(665, 203);
            this._btnThem.Name = "_btnThem";
            this._btnThem.Size = new System.Drawing.Size(150, 31);
            this._btnThem.SizeImage = new System.Drawing.Size(20, 20);
            this._btnThem.TabIndex = 25;
            this._btnThem.Text = "Thêm";
            this._btnThem.TextColor = System.Drawing.Color.Black;
            this._btnThem.UseVisualStyleBackColor = false;
            this._btnThem.Click += new System.EventHandler(this._btnThem_Click);
            // 
            // _btnSua
            // 
            this._btnSua.BackColor = System.Drawing.Color.Turquoise;
            this._btnSua.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnSua.BorderColor = System.Drawing.Color.Black;
            this._btnSua.BorderRadius = 15;
            this._btnSua.BorderSize = 2;
            this._btnSua.FlatAppearance.BorderSize = 0;
            this._btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSua.ForeColor = System.Drawing.Color.Black;
            this._btnSua.Location = new System.Drawing.Point(665, 240);
            this._btnSua.Name = "_btnSua";
            this._btnSua.Size = new System.Drawing.Size(150, 31);
            this._btnSua.SizeImage = new System.Drawing.Size(20, 20);
            this._btnSua.TabIndex = 26;
            this._btnSua.Text = "Sửa";
            this._btnSua.TextColor = System.Drawing.Color.Black;
            this._btnSua.UseVisualStyleBackColor = false;
            this._btnSua.Click += new System.EventHandler(this._btnSua_Click);
            // 
            // _btnXoa
            // 
            this._btnXoa.BackColor = System.Drawing.Color.Turquoise;
            this._btnXoa.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnXoa.BorderColor = System.Drawing.Color.Black;
            this._btnXoa.BorderRadius = 15;
            this._btnXoa.BorderSize = 2;
            this._btnXoa.FlatAppearance.BorderSize = 0;
            this._btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnXoa.ForeColor = System.Drawing.Color.Black;
            this._btnXoa.Location = new System.Drawing.Point(665, 277);
            this._btnXoa.Name = "_btnXoa";
            this._btnXoa.Size = new System.Drawing.Size(150, 31);
            this._btnXoa.SizeImage = new System.Drawing.Size(20, 20);
            this._btnXoa.TabIndex = 27;
            this._btnXoa.Text = "Xóa";
            this._btnXoa.TextColor = System.Drawing.Color.Black;
            this._btnXoa.UseVisualStyleBackColor = false;
            this._btnXoa.Click += new System.EventHandler(this._btnXoa_Click);
            // 
            // FormChiTietGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this._btnXoa);
            this.Controls.Add(this._btnSua);
            this.Controls.Add(this._btnThem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._tbxSoLuongTon);
            this.Controls.Add(this._tbxGiaBan);
            this.Controls.Add(this._tbxGiaNhap);
            this.Controls.Add(this._tbxMoTa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._cbxGiay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._cbxChieuCaoDeGiay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cbxNsx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._cbxSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbxHangGiay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbxMauSac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lsvData);
            this.Name = "FormChiTietGiay";
            this.Text = "FormChiTietGiay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView _lsvData;
        private ColumnHeader Id;
        private ColumnHeader MauSac;
        private ColumnHeader Nsx;
        private ColumnHeader Size;
        private ColumnHeader HangGiay;
        private ColumnHeader ChieuCaoDeGiay;
        private ColumnHeader Giay;
        private ColumnHeader MoTa;
        private ColumnHeader GiaNhap;
        private ColumnHeader GiaBan;
        private ColumnHeader SoLuongTon;
        private ColumnHeader TrangThai;
        private Label label1;
        private RJControls.RJComboBox _cbxMauSac;
        private RJControls.RJComboBox _cbxHangGiay;
        private Label label2;
        private RJControls.RJComboBox _cbxSize;
        private Label label3;
        private RJControls.RJComboBox _cbxNsx;
        private Label label4;
        private RJControls.RJComboBox _cbxChieuCaoDeGiay;
        private Label label5;
        private RJControls.RJComboBox _cbxGiay;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private RJControls.RJTextBox _tbxMoTa;
        private RJControls.RJTextBox _tbxGiaNhap;
        private RJControls.RJTextBox _tbxGiaBan;
        private RJControls.RJTextBox _tbxSoLuongTon;
        private Label label10;
        private RJControls.RJButton _btnThem;
        private RJControls.RJButton _btnSua;
        private RJControls.RJButton _btnXoa;
    }
}