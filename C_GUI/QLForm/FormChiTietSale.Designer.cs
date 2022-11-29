namespace C_GUI.QLForm
{
    partial class FormChiTietSale
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tenmagiamgia = new C_GUI.RJControls.RJComboBox();
            this.cmb_tengiay = new C_GUI.RJControls.RJComboBox();
            this.rdtn_hoatdong = new System.Windows.Forms.RadioButton();
            this.rdtn_khonghoatdong = new System.Windows.Forms.RadioButton();
            this.dgrv_show = new System.Windows.Forms.DataGridView();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Mã Giảm Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng Thái";
            // 
            // cmb_tenmagiamgia
            // 
            this.cmb_tenmagiamgia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_tenmagiamgia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_tenmagiamgia.BorderSize = 1;
            this.cmb_tenmagiamgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_tenmagiamgia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_tenmagiamgia.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_tenmagiamgia.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_tenmagiamgia.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_tenmagiamgia.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_tenmagiamgia.Location = new System.Drawing.Point(171, 12);
            this.cmb_tenmagiamgia.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_tenmagiamgia.Name = "cmb_tenmagiamgia";
            this.cmb_tenmagiamgia.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_tenmagiamgia.Size = new System.Drawing.Size(250, 41);
            this.cmb_tenmagiamgia.TabIndex = 3;
            this.cmb_tenmagiamgia.Texts = "";
            // 
            // cmb_tengiay
            // 
            this.cmb_tengiay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_tengiay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_tengiay.BorderSize = 1;
            this.cmb_tengiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_tengiay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_tengiay.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_tengiay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_tengiay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_tengiay.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_tengiay.Location = new System.Drawing.Point(171, 72);
            this.cmb_tengiay.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_tengiay.Name = "cmb_tengiay";
            this.cmb_tengiay.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_tengiay.Size = new System.Drawing.Size(250, 41);
            this.cmb_tengiay.TabIndex = 4;
            this.cmb_tengiay.Texts = "";
            // 
            // rdtn_hoatdong
            // 
            this.rdtn_hoatdong.AutoSize = true;
            this.rdtn_hoatdong.Location = new System.Drawing.Point(171, 124);
            this.rdtn_hoatdong.Name = "rdtn_hoatdong";
            this.rdtn_hoatdong.Size = new System.Drawing.Size(104, 24);
            this.rdtn_hoatdong.TabIndex = 5;
            this.rdtn_hoatdong.TabStop = true;
            this.rdtn_hoatdong.Text = "Hoạt Động";
            this.rdtn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rdtn_khonghoatdong
            // 
            this.rdtn_khonghoatdong.AutoSize = true;
            this.rdtn_khonghoatdong.Location = new System.Drawing.Point(317, 126);
            this.rdtn_khonghoatdong.Name = "rdtn_khonghoatdong";
            this.rdtn_khonghoatdong.Size = new System.Drawing.Size(151, 24);
            this.rdtn_khonghoatdong.TabIndex = 6;
            this.rdtn_khonghoatdong.TabStop = true;
            this.rdtn_khonghoatdong.Text = "Không Hoạt Động";
            this.rdtn_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // dgrv_show
            // 
            this.dgrv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_show.Location = new System.Drawing.Point(29, 250);
            this.dgrv_show.Name = "dgrv_show";
            this.dgrv_show.RowHeadersWidth = 51;
            this.dgrv_show.RowTemplate.Height = 29;
            this.dgrv_show.Size = new System.Drawing.Size(745, 188);
            this.dgrv_show.TabIndex = 7;
            this.dgrv_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_show_CellContentClick);
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
            this.btn_them.Location = new System.Drawing.Point(528, 18);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(188, 39);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 8;
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
            this.btn_sua.Location = new System.Drawing.Point(528, 72);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(188, 39);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 9;
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
            this.btn_xoa.Location = new System.Drawing.Point(528, 126);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(188, 39);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // FormChiTietSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrv_show);
            this.Controls.Add(this.rdtn_khonghoatdong);
            this.Controls.Add(this.rdtn_hoatdong);
            this.Controls.Add(this.cmb_tengiay);
            this.Controls.Add(this.cmb_tenmagiamgia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietSale";
            this.Text = "FormChiTietSale";
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RJControls.RJComboBox cmb_tenmagiamgia;
        private RJControls.RJComboBox cmb_tengiay;
        private RadioButton rdtn_hoatdong;
        private RadioButton rdtn_khonghoatdong;
        private DataGridView dgrv_show;
        private RJControls.RJButton btn_them;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_xoa;
    }
}