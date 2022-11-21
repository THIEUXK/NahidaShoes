namespace C_GUI.QLForm
{
    partial class FormHangGiay
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
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.rbtn_khonghoatdong = new C_GUI.RJControls.RJRadioButton();
            this.rbtn_hoatdong = new C_GUI.RJControls.RJRadioButton();
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            this.SuspendLayout();
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
            this.btn_xoa.Location = new System.Drawing.Point(323, 245);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(132, 39);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 29;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(169, 245);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(132, 39);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            this.btn_them.Location = new System.Drawing.Point(12, 245);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(132, 39);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 27;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // rbtn_khonghoatdong
            // 
            this.rbtn_khonghoatdong.AutoSize = true;
            this.rbtn_khonghoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_khonghoatdong.Location = new System.Drawing.Point(188, 207);
            this.rbtn_khonghoatdong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
            this.rbtn_khonghoatdong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtn_khonghoatdong.Size = new System.Drawing.Size(156, 24);
            this.rbtn_khonghoatdong.TabIndex = 26;
            this.rbtn_khonghoatdong.TabStop = true;
            this.rbtn_khonghoatdong.Text = "Không hoạt động";
            this.rbtn_khonghoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // rbtn_hoatdong
            // 
            this.rbtn_hoatdong.AutoSize = true;
            this.rbtn_hoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_hoatdong.Location = new System.Drawing.Point(189, 167);
            this.rbtn_hoatdong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtn_hoatdong.Name = "rbtn_hoatdong";
            this.rbtn_hoatdong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtn_hoatdong.Size = new System.Drawing.Size(112, 24);
            this.rbtn_hoatdong.TabIndex = 25;
            this.rbtn_hoatdong.TabStop = true;
            this.rbtn_hoatdong.Text = "Hoạt động";
            this.rbtn_hoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_hoatdong.UseVisualStyleBackColor = true;
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
            this.txt_ten.Location = new System.Drawing.Point(119, 105);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(312, 35);
            this.txt_ten.TabIndex = 24;
            this.txt_ten.Texts = "";
            this.txt_ten.UnderlinedStyle = false;
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
            this.txt_ma.Location = new System.Drawing.Point(119, 51);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(312, 35);
            this.txt_ma.TabIndex = 22;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_GUI.Properties.Resources.z3847898028975_5ee7ff05f8092486aaff7b938d3a1083;
            this.pictureBox1.Location = new System.Drawing.Point(461, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hãng giày";
            // 
            // dgrid_show
            // 
            this.dgrid_show.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Location = new System.Drawing.Point(1, 302);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(731, 194);
            this.dgrid_show.TabIndex = 15;
            this.dgrid_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellContentClick);
            // 
            // FormHangGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 498);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.rbtn_khonghoatdong);
            this.Controls.Add(this.rbtn_hoatdong);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_show);
            this.Name = "FormHangGiay";
            this.Text = "FormHangGiay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJButton btn_xoa;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_them;
        private RJControls.RJRadioButton rbtn_khonghoatdong;
        private RJControls.RJRadioButton rbtn_hoatdong;
        private RJControls.RJTextBox txt_ten;
        private RJControls.RJTextBox txt_ma;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgrid_show;
    }
}