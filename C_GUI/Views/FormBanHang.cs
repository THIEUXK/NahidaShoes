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
        private readonly ListViewColumnSorter lvwColumnSorter;
        private HoaDon? hoaDon;

        public FormBanHang()
        {
            InitializeComponent();
            _qlChiTietGiay = new QLChiTietGiay();
            _qlHoaDonChiTiet = new QLHoaDonChiTiet();
            _qlKhachHang = new QLKhachHang();
            _qlNhanVien = new QLNhanVien();
            _qlHoaDon = new QLHoaDon();
            _qlGiay = new QLGiay();
            LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
            LoadComboBox();
            LoadHoaDonCho(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai == 0).ToList());
            LoadHoaDonChuaThanhToan(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai != 1).ToList());
            idHoaDonDefaut = Guid.NewGuid();
            idHoaDon = idHoaDonDefaut;
            if (_lsvHoaDonCho.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonCho.Items[0].Text);
            }
            LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
            lvwColumnSorter = new ListViewColumnSorter();
            _lsvShowSanPham.ListViewItemSorter = lvwColumnSorter;
            _lsvHoaDonCho.ListViewItemSorter = lvwColumnSorter;
            _lsvGioHang.ListViewItemSorter = lvwColumnSorter;
            _lsvHoaDonChuaThanhToan.ListViewItemSorter = lvwColumnSorter;
            _cbxPhuongThucMua.SelectedItem = "Mua tại cửa hàng";
<<<<<<< HEAD
            LoadData(idHoaDon);
            _cbxTimKiemHoaDon.SelectedItem = "Tất cả hóa đơn";
            _cbxTimKiemGioHang.SelectedItem = "Tất cả mã giày";
            _cbxTimKiemTenGiay.SelectedItem = "Tất cả tên giày";
            _cbxTimKiemMauSac.SelectedItem = "Tất cả màu sắc";
            _cbxTimKiemHangGiay.SelectedItem = "Tất cả hãng giày";
            hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
=======
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
        }

        private void LoadChiTietGiay(List<ChiTietGiayView> lstChiTietGiayView)
        {
            _lsvShowSanPham.Items.Clear();
            foreach (B_BUS.View_Models.ChiTietGiayView item in lstChiTietGiayView)
            {
                string[] row = { item.ChiTietGiay.Id.ToString(), item.Giay.TenGiay, item.MauSac.TenMauSac, item.HangGiay.TenHangGiay, item.Nsx.TenNsx, item.Size.TenSize, item.ChieuCaoDeGiay.MaKichCo, item.ChiTietGiay.GiaBan.ToString(), item.ChiTietGiay.SoLuongTon.ToString(), item.ChiTietGiay.MoTa };
                ListViewItem listViewItem = new(row);
                _ = _lsvShowSanPham.Items.Add(listViewItem);
            }
        }

        private void LoadChiTietHoaDon(List<HoaDonChiTietView> lstHoaDonChiTietView)
        {
            _lsvGioHang.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonChiTietView item in lstHoaDonChiTietView)
            {
                string[] row = { item.HoaDonChiTiet.Id.ToString(), _qlGiay.GetAll().Find(c => c.Id == item.ChTietGiay.IdGiay).MaGiay, item.HoaDonChiTiet.DonGia.ToString(), item.HoaDonChiTiet.SoLuong.ToString() };
                ListViewItem listViewItem = new(row);
                _ = _lsvGioHang.Items.Add(listViewItem);
            }
        }

        private void LoadHoaDonCho(List<HoaDonView> lstHoaDonView)
        {
            _lsvHoaDonCho.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonView item in lstHoaDonView)
            {
<<<<<<< HEAD
                string[] row = { item.HoaDon.Id.ToString(), item.HoaDon.MaHoaDon, item.HoaDon.PhuongThucMua == 0 ? "Mua tại cửa hàng" : "Đặt hàng online", item.HoaDon.TrangThai == 0 ? "Hóa đơn chờ" : item.HoaDon.TrangThai == 1 ? "Hóa đơn đã thanh toán" : item.HoaDon.TrangThai == 2 ? "Hóa đơn đã ship" : "Hóa đơn đã hủy", item.HoaDon.GhiChu };
=======
                string[] row = { item.HoaDon.Id.ToString(), item.HoaDon.MaHoaDon, item.HoaDon.PhuongThucMua == 0 ? "Mua tại cửa hàng" : "Đặt hàng online" };
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
                ListViewItem listViewItem = new(row);
                _ = _lsvHoaDonCho.Items.Add(listViewItem);
            }
            if (_lsvHoaDonCho.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonCho.Items[0].Text);
            }
        }

        private void LoadHoaDonChuaThanhToan(List<HoaDonView> lstHoaDonView)
        {
            _lsvHoaDonChuaThanhToan.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonView item in lstHoaDonView)
            {
                string[] row = { item.HoaDon.Id.ToString(), item.HoaDon.MaHoaDon, item.HoaDon.PhuongThucMua == 0 ? "Mua tại cửa hàng" : "Đặt hàng online" };
                ListViewItem listViewItem = new(row);
                _ = _lsvHoaDonChuaThanhToan.Items.Add(listViewItem);
            }
            if (_lsvHoaDonChuaThanhToan.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonChuaThanhToan.Items[0].Text);
            }
<<<<<<< HEAD
            hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
            LoadData(idHoaDon);
=======
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
        }

        private void LoadComboBox()
        {
            foreach (KhachHang item in _qlKhachHang.GetAll())
            {
                _ = _cbxKhachHang.Items.Add(item.SoCCCD);
            }
        }

        private void _btnTaoHoaDon_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (_cbxKhachHang.SelectedItem != null)
            {
                string maHoaDon = "HD0";
                if (_qlHoaDon.GetAll().Count > 0)
                {
                    maHoaDon = "HD" + _qlHoaDon.GetAll().Max(c => Convert.ToInt32(c.MaHoaDon[2..]) + 1);
                }
                Guid idKhachHang = _qlKhachHang.GetAll().FirstOrDefault(c => c.SoCCCD == _cbxKhachHang.SelectedItem.ToString()).Id;
                Guid idNhanVien = TrangChu.NhanVienLogin.Id;
=======
            if (_cbxNhanVien.SelectedItem != null && _cbxKhachHang.SelectedItem != null && _tbxMaHoaDon.Texts.Trim() != "")
            {
                string maHoaDon = _tbxMaHoaDon.Texts.Trim();
                Guid idKhachHang = _qlKhachHang.GetByMa(_cbxKhachHang.SelectedItem.ToString()).Id;
                Guid idNhanVien = _qlNhanVien.GetByMa(_cbxNhanVien.SelectedItem.ToString()).Id;
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
                int phuongThucMua = _cbxPhuongThucMua.SelectedItem.ToString() == "Đặt hàng online" ? 1 : 0;
                if (_qlHoaDon.CheckMa(maHoaDon))
                {
                    bool thongBao = _qlHoaDon.Add(new HoaDon() { MaHoaDon = maHoaDon, IdKhachHang = idKhachHang, IdNhanVien = idNhanVien, PhuongThucMua = phuongThucMua });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Thêm thành công");
                        LoadHoaDonChuaThanhToan(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai != 1).ToList());
                        LoadHoaDonCho(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai == 0).ToList());
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
                        ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == idGiay);
                        HoaDonChiTiet? hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().FirstOrDefault(c => c.IdHoaDon == idHoaDon && c.IdChiTietGiay == idGiay);
                        if (hoaDonChiTiet == null)
                        {
                            _ = _qlHoaDonChiTiet.Add(new HoaDonChiTiet() { IdHoaDon = idHoaDon, IdChiTietGiay = idGiay, SoLuong = 1, DonGia = Convert.ToSingle(_lsvShowSanPham.SelectedItems[0].SubItems[7].Text) });
                        }
                        else
                        {
                            hoaDonChiTiet.SoLuong++;
                            chiTietGiay.SoLuongTon--;
                            _ = _qlChiTietGiay.Update(chiTietGiay);
                            _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                            LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
                        }
                        LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                        LoadData(idHoaDon);
                    }
                }
            }
        }

        private void _lsvHoaDonCho_DoubleClick(object sender, EventArgs e)
        {
            if (_lsvHoaDonCho.SelectedItems.Count > 0)
            {
<<<<<<< HEAD
                idHoaDon = new Guid(_lsvHoaDon.SelectedItems[0].Text);
                hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
=======
                idHoaDon = new Guid(_lsvHoaDonCho.SelectedItems[0].Text);
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                LoadData(idHoaDon);
            }
        }

        private void _lsvGioHang_DoubleClick(object sender, EventArgs e)
        {
            Guid idHoaDonChiTiet = new(_lsvGioHang.SelectedItems[0].Text);
            HoaDonChiTiet hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().Find(c => c.Id == idHoaDonChiTiet);
            ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == hoaDonChiTiet.IdChiTietGiay);
            if (hoaDonChiTiet.SoLuong > 1)
            {
<<<<<<< HEAD
                Guid idHoaDonChiTiet = new(_lsvGioHang.SelectedItems[0].Text);
                HoaDonChiTiet hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().Find(c => c.Id == idHoaDonChiTiet);
                ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == hoaDonChiTiet.IdChiTietGiay);
                if (hoaDonChiTiet.SoLuong > 1)
                {
                    hoaDonChiTiet.SoLuong--;
                    _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                }
                else
                {
                    _ = _qlHoaDonChiTiet.Delete(hoaDonChiTiet);
                }
                chiTietGiay.SoLuongTon++;
                _ = _qlChiTietGiay.Update(chiTietGiay);
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
                LoadData(idHoaDon);
=======
                hoaDonChiTiet.SoLuong--;
                _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
            }
            else
            {
                _ = _qlHoaDonChiTiet.Delete(hoaDonChiTiet);
            }
            chiTietGiay.SoLuongTon++;
            _ = _qlChiTietGiay.Update(chiTietGiay);
            LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
            LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
        }

        private void _btnThanhToan_Click(object sender, EventArgs e)
        {
            if (idHoaDon != idHoaDonDefaut)
            {
<<<<<<< HEAD
                if (_qlHoaDon.GetAll().Find(c => c.Id == idHoaDon).TrangThai is not 1 and not (-1))
                {
                    if (Convert.ToSingle(_tbxTienThua.Texts) >= 0)
                    {

                        if (hoaDon.PhuongThucMua == 1 && hoaDon.TrangThai != 2)
                        {
                            DialogResult result = MessageBox.Show("Đây là hóa đơn đặt hàng online khi thanh toán sẽ thực hiện ship cho khách. Hãy chắc chắn rằng khách hàng đã đồng ý với các điều khoản của cửa hàng về sản phẩm và đồng ý với phí ship đã định", "Thông báo", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                hoaDon.TrangThai = 1;
                                hoaDon.ThoiGianThanhToan = DateTime.Now;
                                hoaDon.GiamGia = Convert.ToSingle(_tbxGiamGia.Texts);
                                hoaDon.GhiChu = _tbxGhiChu.Texts;
                                _ = _qlHoaDon.Update(hoaDon);
                                _ = MessageBox.Show("Thanh toán thành công");
                                LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                                return;
                            }
                        }
                        hoaDon.TrangThai = 1;
                        hoaDon.ThoiGianThanhToan = DateTime.Now;
                        hoaDon.GiamGia = Convert.ToSingle(_tbxGiamGia.Texts);
                        hoaDon.GhiChu = _tbxGhiChu.Texts;
                        _ = _qlHoaDon.Update(hoaDon);
                        _ = MessageBox.Show("Thanh toán thành công");
                        LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                    }
                }
=======
                FormThanhToan formThanhToan = new();
                formThanhToan.Show();
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
            }
        }

        private void LoadData(Guid? idHoaDon)
        {
<<<<<<< HEAD

            _tbxMaHoaDon.Texts = hoaDon.MaHoaDon;
            float tongTien = 0;
            foreach (HoaDonChiTiet? item in _qlHoaDonChiTiet.GetAll().Where(c => c.IdHoaDon == idHoaDon))
            {
                tongTien += item.SoLuong * item.DonGia;
            }
            _tbxTongTien.Texts = tongTien.ToString();
            _tbxTienKhachDua.Texts = "0";
            _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts) - Convert.ToSingle(_tbxTongTien.Texts)).ToString();
=======
            HoaDonView hoaDon = _qlHoaDon.GetAllView().Find(c => c.HoaDon.Id == idHoaDon);
            _tbxMaHoaDon.Texts = hoaDon.HoaDon.MaHoaDon;
            _cbxKhachHang.SelectedItem = hoaDon.KhachHang.MaKhachHang;
            _cbxNhanVien.SelectedItem = hoaDon.NhanVien.MaNhanVien;
            _cbxPhuongThucMua.SelectedItem = hoaDon.HoaDon.PhuongThucMua == 0 ? "Mua tại cửa hàng" : "Đặt hàng online";
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
        }

        private void _lsvShowSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            _lsvShowSanPham.Sort();
        }

        private void _lsvGioHang_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            _lsvGioHang.Sort();
        }

        private void _lsvHoaDonCho_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            _lsvHoaDonCho.Sort();
        }

        private void _tbxTimKiemThongTinSanPham__TextChanged(object sender, EventArgs e)
        {
            if (_tbxTimKiemThongTinSanPham.Texts.Trim() != "")
            {
                LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.Giay.TenGiay.Contains(_tbxTimKiemThongTinSanPham.Texts.Trim())).ToList());
            }
            else
            {
                LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
            }
        }

        private void _tbxTimKiemGioHang__TextChanged(object sender, EventArgs e)
        {
            if (_tbxTimKiemGioHang.Texts.Trim() != "")
            {
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon && _qlGiay.GetAll().Find(b => b.Id == c.ChTietGiay.IdGiay).MaGiay.Contains(_tbxTimKiemGioHang.Texts.Trim())).ToList());
            }
            else
            {
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
            }
        }

        private void _tbxTimKiemHoaDonCho__TextChanged(object sender, EventArgs e)
        {
            if (_tbxTimKiemHoaDonCho.Texts.Trim() != "")
            {
                LoadHoaDonCho(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai == 0 && c.HoaDon.MaHoaDon.Contains(_tbxTimKiemHoaDonCho.Texts.Trim())).ToList());
            }
            else
            {
                LoadHoaDonCho(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai == 0).ToList());
            }
        }

        private void _btnShipHang_Click(object sender, EventArgs e)
        {
            if (idHoaDon != idHoaDonDefaut)
            {
<<<<<<< HEAD
                if (hoaDon.TrangThai == 0)
=======
                HoaDon hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
                if (hoaDon.TrangThai != 2)
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
                {
                    if (hoaDon.PhuongThucMua == 1)
                    {
                        DialogResult result = MessageBox.Show("Hãy chắc chắn rằng khách hàng đã đồng ý với các điều khoản của cửa hàng về sản phẩm và đồng ý với phí ship đã định", "Thông báo", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            hoaDon.ThoiGianShip = DateTime.Now;
                            hoaDon.TrangThai = 2;
                            _ = _qlHoaDon.Update(hoaDon);
                            _ = MessageBox.Show("Đã gửi yêu cầu ship hàng hóa đơn này");
                            LoadHoaDonCho(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai == 0).ToList());
                        }
                    }
                    else
                    {
                        _ = MessageBox.Show("Hóa đơn mua tại cửa hàng không cần ship");
                    }
                }
                else
                {
                    _ = MessageBox.Show("Đơn hàng đã ship");
                }
            }
        }

        private void _tbxTimKienHoaDonchuaThanhToan__TextChanged(object sender, EventArgs e)
        {
            if (_tbxTimKienHoaDonChuaThanhToan.Texts.Trim() != "")
            {
<<<<<<< HEAD
                float tienKhachDua = Convert.ToSingle(_tbxTienKhachDua.Texts);
            }
            catch (Exception)
            {
                return;
            }
            _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts) - Convert.ToSingle(_tbxTongTien.Texts)).ToString();
        }

        private void _tbxGiamGia__TextChanged(object sender, EventArgs e)
        {
            try
            {
                float giamGia = Convert.ToSingle(_tbxGiamGia.Texts);
            }
            catch (Exception)
            {
                return;
            }
            float tongTien = 0;
            foreach (HoaDonChiTiet? item in _qlHoaDonChiTiet.GetAll().Where(c => c.IdHoaDon == idHoaDon))
            {
                tongTien += item.SoLuong * item.DonGia;
            }
            tongTien -= Convert.ToSingle(_tbxGiamGia.Texts);
            if (tongTien < 0)
            {
                tongTien = 0;
            }
            _tbxTongTien.Texts = tongTien.ToString();
            _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts) - Convert.ToSingle(_tbxTongTien.Texts)).ToString();
        }

        private void _cbxTimKiemHoaDon_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int trangThai = _cbxTimKiemHoaDon.SelectedItem == "Tất cả hóa đơn" ? -2 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn chờ" ? 0 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn đã ship" ? 2 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn đã thanh toán" ? 1 : -1;
            if (trangThai == -2)
            {
                LoadHoaDon(_qlHoaDon.GetAllView().ToList());
=======
                LoadHoaDonChuaThanhToan(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai != 1 && c.HoaDon.MaHoaDon.Contains(_tbxTimKienHoaDonChuaThanhToan.Texts.Trim())).ToList());
>>>>>>> parent of 460c461 (Merge pull request #42 from Phongtxph2301/PH20260)
            }
            else
            {
                LoadHoaDonChuaThanhToan(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai != 1).ToList());
            }
        }

        private void _lsvHoaDonChuaThanhToan_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            _lsvHoaDonChuaThanhToan.Sort();
        }

        private void _lsvHoaDonChuaThanhToan_DoubleClick(object sender, EventArgs e)
        {
            if (_lsvHoaDonChuaThanhToan.SelectedItems.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDonChuaThanhToan.SelectedItems[0].Text);
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                LoadData(idHoaDon);
            }
        }

        private void _btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon.TrangThai is not 1 and not (-1))
            {
                hoaDon.TrangThai = -1;
                _ = _qlHoaDon.Update(hoaDon);
                _ = MessageBox.Show("Đã hủy hóa đơn");
                LoadHoaDon(_qlHoaDon.GetAllView().ToList());
            }
        }
    }
}
