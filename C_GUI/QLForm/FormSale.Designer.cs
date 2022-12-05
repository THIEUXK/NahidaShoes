namespace C_GUI.QLForm
{
    partial class FormSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_hoatdong = new C_GUI.RJControls.RJRadioButton();
            this.rbtn_khonghoatdong = new C_GUI.RJControls.RJRadioButton();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.dgrid_show = new System.Windows.Forms.DataGridView();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.txt_ptgiam = new C_GUI.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sotiengiam = new C_GUI.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_ngaybatdau = new C_GUI.RJControls.RJDatePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_ngayketthuc = new C_GUI.RJControls.RJDatePicker();
            this.a = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new C_GUI.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            this.a.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giảm Giá";
            // 
            // rbtn_hoatdong
            // 
            this.rbtn_hoatdong.AutoSize = true;
            this.rbtn_hoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_hoatdong.Location = new System.Drawing.Point(202, 207);
            this.rbtn_hoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_hoatdong.MinimumSize = new System.Drawing.Size(0, 16);
            this.rbtn_hoatdong.Name = "rbtn_hoatdong";
            this.rbtn_hoatdong.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbtn_hoatdong.Size = new System.Drawing.Size(92, 19);
            this.rbtn_hoatdong.TabIndex = 17;
            this.rbtn_hoatdong.TabStop = true;
            this.rbtn_hoatdong.Text = "Hoạt Động";
            this.rbtn_hoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rbtn_khonghoatdong
            // 
            this.rbtn_khonghoatdong.AutoSize = true;
            this.rbtn_khonghoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_khonghoatdong.Location = new System.Drawing.Point(202, 254);
            this.rbtn_khonghoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_khonghoatdong.MinimumSize = new System.Drawing.Size(0, 16);
            this.rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
            this.rbtn_khonghoatdong.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbtn_khonghoatdong.Size = new System.Drawing.Size(130, 19);
            this.rbtn_khonghoatdong.TabIndex = 18;
            this.rbtn_khonghoatdong.TabStop = true;
            this.rbtn_khonghoatdong.Text = "Không Hoạt Động";
            this.rbtn_khonghoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Turquoise;
            this.btn_them.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_them.BorderColor = System.Drawing.Color.Black;
            this.btn_them.BorderRadius = 15;
            this.btn_them.BorderSize = 2;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(83, 286);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(116, 29);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Turquoise;
            this.btn_sua.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.BorderRadius = 15;
            this.btn_sua.BorderSize = 2;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(263, 286);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 29);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Turquoise;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.BorderRadius = 15;
            this.btn_xoa.BorderSize = 2;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(442, 286);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(116, 29);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dgrid_show
            // 
            this.dgrid_show.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_show.Location = new System.Drawing.Point(3, 372);
            this.dgrid_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(932, 230);
            this.dgrid_show.TabIndex = 22;
            this.dgrid_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellContentClick);
            // 
            // txt_ma
            // 
            this.txt_ma.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ma.BorderColor = System.Drawing.Color.Black;
            this.txt_ma.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_ma.BorderRadius = 15;
            this.txt_ma.BorderSize = 2;
            this.txt_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ma.Location = new System.Drawing.Point(202, 34);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(273, 27);
            this.txt_ma.TabIndex = 23;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
            // 
            // txt_ten
            // 
            this.txt_ten.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ten.BorderColor = System.Drawing.Color.Black;
            this.txt_ten.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_ten.BorderRadius = 15;
            this.txt_ten.BorderSize = 2;
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ten.Location = new System.Drawing.Point(202, 86);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(273, 27);
            this.txt_ten.TabIndex = 24;
            this.txt_ten.Texts = "";
            this.txt_ten.UnderlinedStyle = false;
            // 
            // txt_ptgiam
            // 
            this.txt_ptgiam.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ptgiam.BorderColor = System.Drawing.Color.Black;
            this.txt_ptgiam.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_ptgiam.BorderRadius = 15;
            this.txt_ptgiam.BorderSize = 2;
            this.txt_ptgiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ptgiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ptgiam.Location = new System.Drawing.Point(202, 140);
            this.txt_ptgiam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ptgiam.MaxLength = 20;
            this.txt_ptgiam.Multiline = false;
            this.txt_ptgiam.Name = "txt_ptgiam";
            this.txt_ptgiam.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ptgiam.PasswordChar = false;
            this.txt_ptgiam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ptgiam.PlaceholderText = "";
            this.txt_ptgiam.Size = new System.Drawing.Size(273, 27);
            this.txt_ptgiam.TabIndex = 25;
            this.txt_ptgiam.Texts = "";
            this.txt_ptgiam.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên Chương Trình Khuyến mại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "% Giảm Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mã Giảm Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(504, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số Tiền Giảm Giá";
            // 
            // txt_sotiengiam
            // 
            this.txt_sotiengiam.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sotiengiam.BorderColor = System.Drawing.Color.Black;
            this.txt_sotiengiam.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_sotiengiam.BorderRadius = 15;
            this.txt_sotiengiam.BorderSize = 2;
            this.txt_sotiengiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sotiengiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sotiengiam.Location = new System.Drawing.Point(610, 34);
            this.txt_sotiengiam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_sotiengiam.MaxLength = 20;
            this.txt_sotiengiam.Multiline = false;
            this.txt_sotiengiam.Name = "txt_sotiengiam";
            this.txt_sotiengiam.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_sotiengiam.PasswordChar = false;
            this.txt_sotiengiam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_sotiengiam.PlaceholderText = "";
            this.txt_sotiengiam.Size = new System.Drawing.Size(273, 27);
            this.txt_sotiengiam.TabIndex = 30;
            this.txt_sotiengiam.Texts = "";
            this.txt_sotiengiam.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(522, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ngày Bắt Đầu";
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtp_ngaybatdau.BorderSize = 2;
            this.dtp_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(610, 86);
            this.dtp_ngaybatdau.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(200, 35);
            this.dtp_ngaybatdau.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtp_ngaybatdau.TabIndex = 34;
            this.dtp_ngaybatdau.TextColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(522, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ngày kết Thúc";
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtp_ngayketthuc.BorderSize = 2;
            this.dtp_ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(610, 137);
            this.dtp_ngayketthuc.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(200, 35);
            this.dtp_ngayketthuc.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtp_ngayketthuc.TabIndex = 36;
            this.dtp_ngayketthuc.TextColor = System.Drawing.Color.White;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.a.Controls.Add(this.txt_timkiem);
            this.a.Controls.Add(this.dtp_ngayketthuc);
            this.a.Controls.Add(this.label8);
            this.a.Controls.Add(this.dtp_ngaybatdau);
            this.a.Controls.Add(this.label7);
            this.a.Controls.Add(this.txt_sotiengiam);
            this.a.Controls.Add(this.label5);
            this.a.Controls.Add(this.label4);
            this.a.Controls.Add(this.label3);
            this.a.Controls.Add(this.label2);
            this.a.Controls.Add(this.txt_ptgiam);
            this.a.Controls.Add(this.txt_ten);
            this.a.Controls.Add(this.txt_ma);
            this.a.Controls.Add(this.dgrid_show);
            this.a.Controls.Add(this.btn_xoa);
            this.a.Controls.Add(this.btn_sua);
            this.a.Controls.Add(this.btn_them);
            this.a.Controls.Add(this.rbtn_khonghoatdong);
            this.a.Controls.Add(this.rbtn_hoatdong);
            this.a.Controls.Add(this.label1);
            this.a.Location = new System.Drawing.Point(-22, -35);
            this.a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a.Name = "a";
            this.a.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a.Size = new System.Drawing.Size(938, 604);
            this.a.TabIndex = 1;
            this.a.TabStop = false;
            this.a.Text = "THÔNG TIN SIZE";
            this.a.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BackColor = System.Drawing.SystemColors.Window;
            this.txt_timkiem.BorderColor = System.Drawing.Color.Black;
            this.txt_timkiem.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_timkiem.BorderRadius = 15;
            this.txt_timkiem.BorderSize = 2;
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_timkiem.Location = new System.Drawing.Point(35, 340);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_timkiem.MaxLength = 20;
            this.txt_timkiem.Multiline = false;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_timkiem.PasswordChar = false;
            this.txt_timkiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_timkiem.PlaceholderText = "";
            this.txt_timkiem.Size = new System.Drawing.Size(273, 27);
            this.txt_timkiem.TabIndex = 37;
            this.txt_timkiem.Texts = "";
            this.txt_timkiem.UnderlinedStyle = false;
            this.txt_timkiem._TextChanged += new System.EventHandler(this.txt_timkiem__TextChanged);
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.a);
            this.Name = "FormSale";
            this.Text = "FormSale";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private RJControls.RJRadioButton rbtn_hoatdong;
        private RJControls.RJRadioButton rbtn_khonghoatdong;
        private RJControls.RJButton btn_them;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_xoa;
        private DataGridView dgrid_show;
        private RJControls.RJTextBox txt_ma;
        private RJControls.RJTextBox txt_ten;
        private RJControls.RJTextBox txt_ptgiam;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RJControls.RJTextBox txt_sotiengiam;
        private Label label7;
        private RJControls.RJDatePicker dtp_ngaybatdau;
        private Label label8;
        private RJControls.RJDatePicker dtp_ngayketthuc;
        private GroupBox a;
        private RJControls.RJTextBox txt_timkiem;
    }
}