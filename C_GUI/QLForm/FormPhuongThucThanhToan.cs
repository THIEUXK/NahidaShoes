using A_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.QLForm
{
    public partial class FormPhuongThucThanhToan : Form
    {
        public IQLPhuongThucThanhToan _IQlPhuongThucThanhToan;
        private Guid _ID;

        public FormPhuongThucThanhToan()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_show.ColumnCount = 5;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "mapttt";
            dgrid_show.Columns[3].Name = "tenpttt";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = true;
            foreach (var a in _IQlPhuongThucThanhToan.GetAllView())
            {
                _ = dgrid_show.Rows.Add(stt++, a.PhuongThucThanhToan.Id,a.PhuongThucThanhToan.MaPttt,a.PhuongThucThanhToan.TenPttt);
            }
        }

        public PhuongThucThanhToan GetvaluaContro()
        {
            return new PhuongThucThanhToan()
            {
                MaPttt = txt_mapttt.Texts,
                TenPttt = txt_tenpttt.Texts
                

            };
        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_mapttt.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_tenpttt.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
        }

    

        private void btn_them_Click(object sender, EventArgs e)
        {
            _IQlPhuongThucThanhToan.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQlPhuongThucThanhToan.Update(new A_DAL.Entities.PhuongThucThanhToan()
            {
                Id = _ID,
                MaPttt = txt_mapttt.Texts,
                TenPttt = txt_tenpttt.Texts
            });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQlPhuongThucThanhToan.Delete(_IQlPhuongThucThanhToan.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void dgrid_show_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_mapttt.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_tenpttt.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
           
        }
    }
}
