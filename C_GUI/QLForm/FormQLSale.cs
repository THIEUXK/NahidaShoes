using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.QLForm
{
    public partial class FormQLSale : Form
    {
        private IQLSale qlSale;
        private Guid idwhenClick;
        public FormQLSale()
        {
            InitializeComponent();
            qlSale = new QLSale();
            LoadData();
        }

        public void LoadData()
        {
            dgrv_show.ColumnCount = 7;
            dgrv_show.Columns[0].Name = "ID";
            dgrv_show.Columns[0].Visible =false;
            dgrv_show.Columns[1].Name = "Mã Giảm Giá";
            dgrv_show.Columns[2].Name = "Tên Chương Trình";
            dgrv_show.Columns[3].Name = "Lựa Chọn Giảm Giá";
            dgrv_show.Columns[4].Name = "Ngày Bắt Đầu";
            dgrv_show.Columns[5].Name = "Ngày Kết Thúc";
            dgrv_show.Columns[6].Name = "Trạng Thai";
            dgrv_show.Rows.Clear();
            foreach (var a in qlSale.GetAllView())
            {
                dgrv_show.Rows.Add(a.Sale.Id, a.Sale.MaGiamGia, a.Sale.TenChuongTrinh, a.Sale.LuaChonGiamGia,
                    a.Sale.NgayBatDau, a.Sale.NgayBatDau, a.Sale.NgayBatDau, a.Sale.NgayKetThuc,a.Sale.TrangThai==1?"Hoạt Động":"Không Hoạt Dông");
            }
        }

        public Sale GetvalueControl()
        {
            return new Sale()
            {
                Id = Guid.NewGuid(),
                MaGiamGia = tbx_magiamgia.Texts,
                TenChuongTrinh = tbx_tenchuongtrinh.Texts,
                LuaChonGiamGia = int.Parse( tbx_luachongiamgia.Texts),
                NgayBatDau = dtpk_ngaybatdau.Value,
                NgayKetThuc = dtpk_ngayketthuc.Value,
                TrangThai =  rdtn_hoatdong.Checked==true?1:0,
            };
        }

        private void dgrv_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index =e.RowIndex;
            idwhenClick = Guid.Parse(dgrv_show.Rows[index].Cells[0].Value.ToString());
            tbx_magiamgia.Texts = dgrv_show.Rows[index].Cells[1].Value.ToString();
            tbx_tenchuongtrinh.Texts = dgrv_show.Rows[index].Cells[2].Value.ToString();
            tbx_luachongiamgia.Texts = dgrv_show.Rows[index].Cells[3].Value.ToString();
            dtpk_ngaybatdau.Value = DateTime.Parse(dgrv_show.Rows[index].Cells[4].Value.ToString());
            dtpk_ngayketthuc.Value = DateTime.Parse(dgrv_show.Rows[index].Cells[5].Value.ToString());
            if (dgrv_show.Rows[index].Cells[6].Value.ToString()=="Hoạt Động")
            {
                rdtn_hoatdong.Checked = true;
                rdtn_khonghoatdong.Checked = false;
            }
            else
            {
                rdtn_khonghoatdong.Checked = true;
                rdtn_hoatdong.Checked=false;
            }


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           qlSale.Add(GetvalueControl());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (qlSale.Update(new Sale
                {
                    Id = idwhenClick,
                    MaGiamGia = tbx_magiamgia.Texts,
                    TenChuongTrinh = tbx_tenchuongtrinh.Texts,
                    LuaChonGiamGia = int.Parse(tbx_luachongiamgia.Texts),
                    NgayBatDau = dtpk_ngaybatdau.Value,
                    NgayKetThuc = dtpk_ngayketthuc.Value,
                    TrangThai = rdtn_hoatdong.Checked == true ? 1 : 0,

                }))
            {
                MessageBox.Show("Sửa Thành Công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa Thất bại");
            }
        

    }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongbao = qlSale.Delete(qlSale.GetAll().Find(c => c.Id == idwhenClick));
            if (thongbao)
            {
                MessageBox.Show("xóa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }
    }
}
