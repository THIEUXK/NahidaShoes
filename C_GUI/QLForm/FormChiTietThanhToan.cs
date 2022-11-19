using A_DAL.Entities;
using B_BUS.View_Models;
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
    public partial class FormChiTietThanhToan : Form
    {
        public IQLChiTietThanhToan _IQlChiTietThanhToan;
        public IQLHoaDon _IQlHoaDon;
        public IQLPhuongThucThanhToan _IQlPhuongThucThanhToan;
        private Guid _ID;
        public FormChiTietThanhToan()
        {
            InitializeComponent();
            _IQlChiTietThanhToan = new QLChiTietThanhToan();
            _IQlHoaDon = new QLHoaDon();
            _IQlPhuongThucThanhToan = new QlPhuongThucThanhToan();
            Loadcmb();
            LoadData();

        }
        public void Loadcmb()
        {

            foreach (var a in _IQlPhuongThucThanhToan.GetAll())
            {
                _ = cmb_phuongthuc.Items.Add(a.TenPhuongThucThanhToan);
            }
            foreach (var a in _IQlHoaDon.GetAll())
            {
                _ = cmb_hoadon.Items.Add(a.MaHoaDon);
            }
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_shownhanvien.ColumnCount = 7;
            dgrid_shownhanvien.Columns[0].Name = "stt";
            dgrid_shownhanvien.Columns[1].Name = "id";
            dgrid_shownhanvien.Columns[2].Name = "Phương Thức thanh toán";
            dgrid_shownhanvien.Columns[3].Name = "ma hoa don";
            dgrid_shownhanvien.Columns[4].Name = "so tien thanh toan";
            dgrid_shownhanvien.Columns[5].Name = "ghi chu";
            dgrid_shownhanvien.Columns[6].Name = "trang thai";
            dgrid_shownhanvien.Rows.Clear();
            dgrid_shownhanvien.Columns[1].Visible = true;
            foreach (var a in _IQlChiTietThanhToan.GetAllView())
            {

                _ = dgrid_shownhanvien.Rows.Add(stt++, a.ChiTietThanhToan.Id, a.ChiTietThanhToan.IdPhuongThucThanhToan, a.ChiTietThanhToan.IdHoaDon, a.ChiTietThanhToan.SoTienThanhToan, a.ChiTietThanhToan.GhiChu, a.ChiTietThanhToan.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }

        public ChiTietThanhToan GetvaluaContro()
        {
            var x = _IQlPhuongThucThanhToan.GetAllView().FirstOrDefault(c => c.PhuongThucThanhToan.TenPhuongThucThanhToan == cmb_phuongthuc.Texts);

            var y = _IQlHoaDon.GetAllView().FirstOrDefault(c => c.HoaDon.MaHoaDon == cmb_hoadon.Texts);
            return new ChiTietThanhToan()
            {
                SoTienThanhToan = int.Parse(txt_sotienthanhtoan.Texts),
                GhiChu = txt_ghichu.Texts,
                TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0,
                IdPhuongThucThanhToan = x.PhuongThucThanhToan.Id,
                IdHoaDon = y.HoaDon.Id,
            };
        }

        private void dgrid_shownhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_shownhanvien.Rows[index].Cells[1].Value.ToString());
            txt_sotienthanhtoan.Texts = dgrid_shownhanvien.Rows[index].Cells[4].Value.ToString();
            txt_ghichu.Texts = dgrid_shownhanvien.Rows[index].Cells[5].Value.ToString();
            //txt_email.Texts = dgrid_shownhanvien.Rows[index].Cells[4].Value.ToString();
            if (dgrid_shownhanvien.Rows[index].Cells[6].Value.ToString() == "hoat dong")
            {
                rbtn_hoatdong.Checked = true;
            }
            if (dgrid_shownhanvien.Rows[index].Cells[6].Value.ToString() == "khong hoat dong")
            {
                rbtn_khonghoatdong.Checked = true;
            }

            var a = _IQlChiTietThanhToan.GetAllView().FirstOrDefault(c => c.ChiTietThanhToan.Id == _ID).ChiTietThanhToan;
            cmb_phuongthuc.SelectedItem = _IQlChiTietThanhToan.GetAllView().FirstOrDefault(c => c.ChiTietThanhToan.IdPhuongThucThanhToan == a.IdPhuongThucThanhToan).PhuongThucThanhToan.TenPhuongThucThanhToan;
            cmb_hoadon.SelectedItem = _IQlChiTietThanhToan.GetAllView().FirstOrDefault(c => c.ChiTietThanhToan.IdHoaDon == a.IdHoaDon).HoaDon.MaHoaDon;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _ = _IQlChiTietThanhToan.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var x = _IQlPhuongThucThanhToan.GetAllView().FirstOrDefault(c => c.PhuongThucThanhToan.TenPhuongThucThanhToan == cmb_phuongthuc.Texts);

            var y = _IQlHoaDon.GetAllView().FirstOrDefault(c => c.HoaDon.MaHoaDon == cmb_hoadon.Texts);
            bool thongBao = _IQlChiTietThanhToan.Update(new A_DAL.Entities.ChiTietThanhToan()
            {
                Id = _ID,
                SoTienThanhToan = int.Parse(txt_sotienthanhtoan.Texts),
                GhiChu = txt_ghichu.Texts,
                TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0,
                IdPhuongThucThanhToan = x.PhuongThucThanhToan.Id,
                IdHoaDon = y.HoaDon.Id,
            });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }
    

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQlChiTietThanhToan.Delete(_IQlChiTietThanhToan.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }
}
