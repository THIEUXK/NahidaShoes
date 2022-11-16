using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using C_GUI.RJControls;

namespace C_GUI.Views
{
    public partial class FormBanHang : Form
    {
        private readonly IQLChiTietGiay _qlChiTietGiay;
        private readonly IQLKhachHang _qlKhachHang;
        private readonly IQLNhanVien _qlNhanVien;
        private readonly IQLHoaDon _qlHoaDon;
        private readonly List<HoaDon> _lstHoaDon;
        private Point pointHoaDon;

        public FormBanHang()
        {
            InitializeComponent();
            _lstHoaDon = new();
            _qlChiTietGiay = new QLChiTietGiay();
            _qlKhachHang = new QLKhachHang();
            _qlNhanVien = new QLNhanVien();
            _qlHoaDon = new QLHoaDon();
            pointHoaDon = new Point(6, 21);
            LoadChiTietGiay();
            LoadComboBox();
        }
        private void LoadChiTietGiay()
        {
            _lsvShowSanPham.Items.Clear();
            foreach (B_BUS.View_Models.ChiTietGiayView item in _qlChiTietGiay.GetAllView())
            {
                string[] row = { item.Giay.TenGiay, item.MauSac.TenMauSac, item.HangGiay.TenHangGiay, item.Nsx.TenNsx, item.Size.TenSize, item.ChieuCaoDeGiay.MaKichCo, item.ChiTietGiay.GiaBan.ToString(), item.ChiTietGiay.SoLuongTon.ToString(), item.ChiTietGiay.MoTa };
                ListViewItem listViewItem = new(row);
                _ = _lsvShowSanPham.Items.Add(listViewItem);
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
                if (_qlHoaDon.CheckMa(_tbxMaHoaDon.Texts.Trim()))
                {
                    string maHoaDon = _tbxMaHoaDon.Texts.Trim();
                    Guid idKhachHang = _qlKhachHang.GetByMa(_cbxKhachHang.SelectedItem.ToString()).Id;
                    Guid idNhanVien = _qlNhanVien.GetByMa(_cbxNhanVien.SelectedItem.ToString()).Id;
                    bool thongBao = _qlHoaDon.Add(new HoaDon() { MaHoaDon = maHoaDon, IdKhachHang = idKhachHang, IdNhanVien = idNhanVien });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Thêm thành công");
                        RJButton button = new()
                        {
                            Text = maHoaDon,
                            Location = pointHoaDon
                        };
                        groupBox4.Controls.Add(button);
                        pointHoaDon = pointHoaDon.X < 630 ? new Point(pointHoaDon.X + 156, pointHoaDon.Y) : new Point(6, pointHoaDon.Y + 37);
                    }
                }
                else
                {
                    _ = MessageBox.Show("Mã hóa đơn đã tồn tại");
                }
            }
        }
    }
}
