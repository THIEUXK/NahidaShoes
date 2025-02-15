﻿using A_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.QLForm
{
    public partial class FormMauSac : Form
    {
        public IQLMauSac _IQlMauSac;
        private Guid _ID;
        public FormMauSac()
        {
            _IQlMauSac = new QLMauSac();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_show.ColumnCount = 5;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "ma";
            dgrid_show.Columns[3].Name = "ten";
            dgrid_show.Columns[4].Name = "trang thai";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = true;
            foreach (var a in _IQlMauSac.GetAllView())
            {
                dgrid_show.Rows.Add(stt++, a.MauSac.Id, a.MauSac.MaMauSac, a.MauSac.TenMauSac, a.MauSac.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }

        public MauSac GetvaluaContro()
        {
            return new MauSac()
            {
                MaMauSac = txt_ma.Texts,
                TenMauSac = txt_ten.Texts,
                TrangThai = (rbtn_hoatdong.Checked == true ? 1 : 0),
            };
        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
            if ((dgrid_show.Rows[index].Cells[4].Value.ToString()) == "hoat dong")
            {
                rbtn_hoatdong.Checked = true;
            }
            if ((dgrid_show.Rows[index].Cells[4].Value.ToString()) == "khong hoat dong")
            {
                rbtn_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _IQlMauSac.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
