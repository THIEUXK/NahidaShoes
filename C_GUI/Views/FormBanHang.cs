using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.Views
{
    public partial class FormBanHang : Form
    {
        private readonly IQLChiTietGiay _qlChiTietGiay;
        private readonly IQLHoaDonChiTiet _qlHoaDonChiTiet;
        private readonly IQLKhachHang _qlKhachHang;
        private readonly IQLNhanVien _qlNhanVien;
        private readonly IQLHoaDon _qlHoaDon;
        private readonly IQLGiay _qlGiay;
        public static Guid idHoaDon;
        private readonly Guid idHoaDonDefaut;

        public FormBanHang()
        {
            InitializeComponent();
            _qlChiTietGiay = new QLChiTietGiay();
            _qlHoaDonChiTiet = new QLHoaDonChiTiet();
            _qlKhachHang = new QLKhachHang();
            _qlNhanVien = new QLNhanVien();
            _qlHoaDon = new QLHoaDon();
            _qlGiay = new QLGiay();
            LoadChiTietGiay();
            LoadComboBox();
            LoadHoaDonCho();
            idHoaDonDefaut = Guid.NewGuid();
            idHoaDon = idHoaDonDefaut;
            if (_lsvHoaDonCho.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonCho.Items[0].Text);
            }
            LoadChiTietHoaDon(idHoaDon);
            LoadHoaDonKetThuc();
        }
        private void LoadChiTietGiay()
        {
            _lsvShowSanPham.Items.Clear();
            foreach (B_BUS.View_Models.ChiTietGiayView item in _qlChiTietGiay.GetAllView())
            {
                string[] row = { item.ChiTietGiay.Id.ToString(), item.Giay.TenGiay, item.MauSac.TenMauSac, item.HangGiay.TenHangGiay, item.Nsx.TenNsx, item.Size.TenSize, item.ChieuCaoDeGiay.MaKichCo, item.ChiTietGiay.GiaBan.ToString(), item.ChiTietGiay.SoLuongTon.ToString(), item.ChiTietGiay.MoTa };
                ListViewItem listViewItem = new(row);
                _ = _lsvShowSanPham.Items.Add(listViewItem);
            }
        }

        private void LoadChiTietHoaDon(Guid? idHoaDon)
        {
            _lsvGioHang.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonChiTietView item in _qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon))
            {
                string[] row = { item.HoaDonChiTiet.Id.ToString(), _qlGiay.GetAll().Find(c => c.Id == item.ChTietGiay.IdGiay).MaGiay, item.HoaDonChiTiet.DonGia.ToString(), item.HoaDonChiTiet.SoLuong.ToString() };
                ListViewItem listViewItem = new(row);
                _ = _lsvGioHang.Items.Add(listViewItem);
            }
        }

        private void LoadHoaDonCho()
        {
            _lsvHoaDonCho.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonView item in _qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai == 0))
            {
                string[] row = { item.HoaDon.Id.ToString(), item.HoaDon.MaHoaDon };
                ListViewItem listViewItem = new(row);
                _ = _lsvHoaDonCho.Items.Add(listViewItem);
            }
            if (_lsvHoaDonCho.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonCho.Items[0].Text);
            }
        }

        private void LoadHoaDonKetThuc()
        {
            _lsvHoaDonKetThuc.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonView item in _qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai != 0))
            {
                string[] row = { item.HoaDon.Id.ToString(), item.HoaDon.MaHoaDon, item.HoaDon.ThoiGianTao.ToString(), item.HoaDon.ThoiGianThanhToan.ToString(), item.NhanVien.MaNhanVien, item.KhachHang.MaKhachHang, item.HoaDon.GiamGia.ToString(), item.HoaDon.GhiChu, item.HoaDon.TrangThai.ToString() };
                ListViewItem listViewItem = new(row);
                _ = _lsvHoaDonKetThuc.Items.Add(listViewItem);
            }
            if (_lsvHoaDonCho.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonCho.Items[0].Text);
            }
        }

        private void LoadComboBox()
        {
            foreach (KhachHang item in _qlKhachHang.GetAll())
            {
                _ = _cbxKhachHang.Items.Add(item.MaKhachHang);
            }
            foreach (NhanVien item in _qlNhanVien.GetAll())
            {
                _ = _cbxNhanVien.Items.Add(item.MaNhanVien);
            }
        }

        private void _btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (_cbxNhanVien.SelectedItem != null && _cbxKhachHang.SelectedItem != null && _tbxMaHoaDon.Texts.Trim() != "")
            {
                string maHoaDon = _tbxMaHoaDon.Texts.Trim();
                Guid idKhachHang = _qlKhachHang.GetByMa(_cbxKhachHang.SelectedItem.ToString()).Id;
                Guid idNhanVien = _qlNhanVien.GetByMa(_cbxNhanVien.SelectedItem.ToString()).Id;
                if (_qlHoaDon.CheckMa(maHoaDon))
                {
                    bool thongBao = _qlHoaDon.Add(new HoaDon() { MaHoaDon = maHoaDon, IdKhachHang = idKhachHang, IdNhanVien = idNhanVien });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Thêm thành công");
                        LoadHoaDonCho();
                    }
                }
                else
                {
                    _ = MessageBox.Show("Mã hóa đơn đã tồn tại");
                }
            }
        }

        private void _lsvShowSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (idHoaDon != idHoaDonDefaut)
            {
                if (_qlHoaDon.GetAll().Find(c => c.Id == idHoaDon).TrangThai == 0)
                {
                    if (_lsvShowSanPham.SelectedItems.Count > 0)
                    {
                        Guid idGiay = new(_lsvShowSanPham.SelectedItems[0].Text);
                        HoaDonChiTiet? hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().FirstOrDefault(c => c.IdHoaDon == idHoaDon && c.IdChiTietGiay == idGiay);
                        if (hoaDonChiTiet == null)
                        {
                            _ = _qlHoaDonChiTiet.Add(new HoaDonChiTiet() { IdHoaDon = idHoaDon, IdChiTietGiay = idGiay, SoLuong = 1, DonGia = Convert.ToSingle(_lsvShowSanPham.SelectedItems[0].SubItems[7].Text) });
                        }
                        else
                        {
                            hoaDonChiTiet.SoLuong++;
                            _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                        }
                    }
                }
                LoadChiTietHoaDon(idHoaDon);
            }
        }

        private void _lsvHoaDonCho_DoubleClick(object sender, EventArgs e)
        {
            if (_lsvHoaDonCho.SelectedItems.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonCho.SelectedItems[0].Text);
            }
            LoadChiTietHoaDon(idHoaDon);
            LoadData(idHoaDon);
        }

        private void _lsvGioHang_DoubleClick(object sender, EventArgs e)
        {
            if (_qlHoaDon.GetAll().Find(c => c.Id == idHoaDon).TrangThai == 0)
            {
                Guid idHoaDonChiTiet = new(_lsvGioHang.SelectedItems[0].Text);
                HoaDonChiTiet hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().Find(c => c.Id == idHoaDonChiTiet);
                if (hoaDonChiTiet.SoLuong > 1)
                {
                    hoaDonChiTiet.SoLuong--;
                    _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                }
                else
                {
                    _ = _qlHoaDonChiTiet.Delete(hoaDonChiTiet);
                }
            }
            LoadChiTietHoaDon(idHoaDon);
        }

        private void _lsvHoaDonKetThuc_DoubleClick(object sender, EventArgs e)
        {
            if (_lsvHoaDonKetThuc.SelectedItems.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonKetThuc.SelectedItems[0].Text);
            }
            LoadChiTietHoaDon(idHoaDon);
            LoadData(idHoaDon);
        }

        private void _btnThanhToan_Click(object sender, EventArgs e)
        {
            if (idHoaDon != idHoaDonDefaut)
            {
                HoaDon hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
                if (hoaDon.TrangThai != 0)
                {
                    _ = MessageBox.Show("Hóa đơn đã xử lí");
                }
                else
                {
                    FormThanhToan formThanhToan = new();
                    formThanhToan.Show();
                }
            }
        }

        private void LoadData(Guid? idHoaDon)
        {
            HoaDonView hoaDon = _qlHoaDon.GetAllView().Find(c => c.HoaDon.Id == idHoaDon);
            _tbxMaHoaDon.Texts = hoaDon.HoaDon.MaHoaDon;
            _cbxKhachHang.SelectedItem = hoaDon.KhachHang.MaKhachHang;
            _cbxNhanVien.SelectedItem = hoaDon.NhanVien.MaNhanVien;
        }
    }
}
