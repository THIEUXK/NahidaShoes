namespace C_GUI.QLForm
{
    partial class FormNsx
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
            this.dgrid_show = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.txt_diachi = new C_GUI.RJControls.RJTextBox();
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_show
            // 
            this.dgrid_show.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Location = new System.Drawing.Point(1, 277);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(708, 168);
            this.dgrid_show.TabIndex = 0;
            this.dgrid_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nsx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa Chỉ";
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
            this.txt_ma.Location = new System.Drawing.Point(139, 47);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(312, 35);
            this.txt_ma.TabIndex = 7;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_diachi.BorderColor = System.Drawing.Color.Black;
            this.txt_diachi.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_diachi.BorderRadius = 15;
            this.txt_diachi.BorderSize = 2;
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_diachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_diachi.Location = new System.Drawing.Point(139, 153);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.MaxLength = 20;
            this.txt_diachi.Multiline = false;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_diachi.PasswordChar = false;
            this.txt_diachi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_diachi.PlaceholderText = "";
            this.txt_diachi.Size = new System.Drawing.Size(312, 35);
            this.txt_diachi.TabIndex = 8;
            this.txt_diachi.Texts = "";
            this.txt_diachi.UnderlinedStyle = false;
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
            this.txt_ten.Location = new System.Drawing.Point(139, 101);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(312, 35);
            this.txt_ten.TabIndex = 9;
            this.txt_ten.Texts = "";
            this.txt_ten.UnderlinedStyle = false;
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
            this.btn_them.Location = new System.Drawing.Point(12, 220);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(132, 39);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 12;
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
            this.btn_sua.Location = new System.Drawing.Point(168, 220);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(132, 39);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 13;
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
            this.btn_xoa.Location = new System.Drawing.Point(319, 220);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(132, 39);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_GUI.Properties.Resources.z3847898028975_5ee7ff05f8092486aaff7b938d3a1083;
            this.pictureBox1.Location = new System.Drawing.Point(470, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormNsx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 446);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_show);
            this.Name = "FormNsx";
            this.Text = "FormNsx";
            this.Load += new System.EventHandler(this.FormNsx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgrid_show;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RJControls.RJTextBox txt_ma;
        private RJControls.RJTextBox txt_diachi;
        private RJControls.RJTextBox txt_ten;
        private RJControls.RJButton btn_them;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_xoa;
        private PictureBox pictureBox1;
    }
}