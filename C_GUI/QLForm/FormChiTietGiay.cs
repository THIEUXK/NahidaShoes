using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.QLForm
{
    public partial class FormChiTietGiay : Form
    {
        private readonly IQLChiTietGiay _qlChiTietGiay;
        private readonly IQLChieuCaoDeGiay _qlChieuCaoDeGiay;
        private readonly IQLMauSac _qlMauSac;
        private readonly IQLNsx _qlNsx;
        private readonly IQLSize _qlSize;
        private readonly IQLHangGiay _qlHangGiay;
        private readonly IQLGiay _qlGiay;
        private Guid idSelect;
        private readonly Guid defaultId;
        private readonly List<Guid> mangMa;

        public FormChiTietGiay()
        {
            InitializeComponent();
            _qlChiTietGiay = new QLChiTietGiay();
            _qlChieuCaoDeGiay = new QLChieuCaoDeGiay();
            _qlMauSac = new QLMauSac();
            _qlNsx = new QLNsx();
            _qlSize = new QLSize();
            _qlHangGiay = new QLHangGiay();
            _qlGiay = new QLGiay();
            LoadView();
            LoadComboBox();
            defaultId = Guid.NewGuid();
            idSelect = defaultId;
            mangMa = new();
        }

        private void LoadView()
        {
            _lsvData.Items.Clear();
            foreach (B_BUS.View_Models.ChiTietGiayView item in _qlChiTietGiay.GetAllView())
            {
                string[] row = { item.ChiTietGiay.Id.ToString(), item.MauSac.MaMauSac, item.Nsx.MaNsx, item.Size.MaSize, item.HangGiay.MaHangGiay, item.ChieuCaoDeGiay.MaKichCo, item.Giay.MaGiay, item.ChiTietGiay.MoTa, item.ChiTietGiay.GiaNhap.ToString(), item.ChiTietGiay.GiaBan.ToString(), item.ChiTietGiay.SoLuongTon.ToString(), item.ChiTietGiay.TrangThai.ToString() };
                ListViewItem listViewItem = new(row);
                _ = _lsvData.Items.Add(listViewItem);
            }
            idSelect = defaultId;
        }

        private void LoadComboBox()
        {
            foreach (ChieuCaoDeGiay item in _qlChieuCaoDeGiay.GetAll())
            {
                _ = _cbxChieuCaoDeGiay.Items.Add(item.MaKichCo);
            }
            foreach (Giay item in _qlGiay.GetAll())
            {
                _ = _cbxGiay.Items.Add(item.MaGiay);
            }
            foreach (HangGiay item in _qlHangGiay.GetAll())
            {
                _ = _cbxHangGiay.Items.Add(item.MaHangGiay);
            }
            foreach (MauSac item in _qlMauSac.GetAll())
            {
                _ = _cbxMauSac.Items.Add(item.MaMauSac);
            }
            foreach (Nsx item in _qlNsx.GetAll())
            {
                _ = _cbxNsx.Items.Add(item.MaNsx);
            }
            foreach (A_DAL.Entities.Size item in _qlSize.GetAll())
            {
                _ = _cbxSize.Items.Add(item.MaSize);
            }
        }

        private void _btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                float giaNhap = Convert.ToSingle(_tbxGiaNhap.Texts.Trim());
                float giaBan = Convert.ToSingle(_tbxGiaBan.Texts.Trim());
                int soLuongTon = Convert.ToInt32(_tbxSoLuongTon.Texts.Trim());
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                return;
            }
            if (_cbxSize.SelectedItem != null && _cbxNsx.SelectedItem != null && _cbxMauSac.SelectedItem != null && _cbxHangGiay.SelectedItem != null && _cbxGiay.SelectedItem != null && _cbxChieuCaoDeGiay.SelectedItem != null)
            {
                Guid idSize = _qlSize.GetByMa(_cbxSize.SelectedItem.ToString()).Id;
                Guid idNsx = _qlNsx.GetByMa(_cbxNsx.SelectedItem.ToString()).Id;
                Guid idMauSac = _qlMauSac.GetByMa(_cbxMauSac.SelectedItem.ToString()).Id;
                Guid idHangGiay = _qlHangGiay.GetByMa(_cbxHangGiay.SelectedItem.ToString()).Id;
                Guid idGiay = _qlGiay.GetByMa(_cbxGiay.SelectedItem.ToString()).Id;
                Guid idChieuCaoDeGiay = _qlChieuCaoDeGiay.GetByMa(_cbxChieuCaoDeGiay.SelectedItem.ToString()).Id;
                string? moTa = _tbxMoTa.Texts.Trim() == "" ? null : _tbxMoTa.Texts.Trim();
                float giaNhap = Convert.ToSingle(_tbxGiaNhap.Texts.Trim());
                float giaBan = Convert.ToSingle(_tbxGiaBan.Texts.Trim());
                int soLuongTon = Convert.ToInt32(_tbxSoLuongTon.Texts.Trim());
                if (_qlChiTietGiay.CheckMa(idSize, idNsx, idMauSac, idHangGiay, idGiay, idChieuCaoDeGiay))
                {
                    bool thongBao = _qlChiTietGiay.Add(new A_DAL.Entities.ChiTietGiay() { IdSize = idSize, IdNsx = idNsx, IdMauSac = idMauSac, IdHangGiay = idHangGiay, IdGiay = idGiay, IdChieuCaoDeGiay = idChieuCaoDeGiay, MoTa = moTa, GiaNhap = giaNhap, GiaBan = giaBan, SoLuongTon = soLuongTon });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Thêm thành công");
                        LoadView();
                    }
                }
                else
                {
                    _ = MessageBox.Show("Mã hóa đơn đã tồn tại");
                }
            }
            else
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
            }
        }

        private void _btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                float giaNhap = Convert.ToSingle(_tbxGiaNhap.Texts.Trim());
                float giaBan = Convert.ToSingle(_tbxGiaBan.Texts.Trim());
                int soLuongTon = Convert.ToInt32(_tbxSoLuongTon.Texts.Trim());
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                return;
            }
            if (idSelect != defaultId)
            {
                if (_cbxSize.SelectedItem != null && _cbxNsx.SelectedItem != null && _cbxMauSac.SelectedItem != null && _cbxHangGiay.SelectedItem != null && _cbxGiay.SelectedItem != null && _cbxChieuCaoDeGiay.SelectedItem != null)
                {
                    Guid idSize = _qlSize.GetByMa(_cbxSize.SelectedItem.ToString()).Id;
                    Guid idNsx = _qlNsx.GetByMa(_cbxNsx.SelectedItem.ToString()).Id;
                    Guid idMauSac = _qlMauSac.GetByMa(_cbxMauSac.SelectedItem.ToString()).Id;
                    Guid idHangGiay = _qlHangGiay.GetByMa(_cbxHangGiay.SelectedItem.ToString()).Id;
                    Guid idGiay = _qlGiay.GetByMa(_cbxGiay.SelectedItem.ToString()).Id;
                    Guid idChieuCaoDeGiay = _qlChieuCaoDeGiay.GetByMa(_cbxChieuCaoDeGiay.SelectedItem.ToString()).Id;
                    string? moTa = _tbxMoTa.Texts.Trim() == "" ? null : _tbxMoTa.Texts.Trim();
                    float giaNhap = Convert.ToSingle(_tbxGiaNhap.Texts.Trim());
                    float giaBan = Convert.ToSingle(_tbxGiaBan.Texts.Trim());
                    int soLuongTon = Convert.ToInt32(_tbxSoLuongTon.Texts.Trim());
                    if (_qlChiTietGiay.CheckMa(idSize, idNsx, idMauSac, idHangGiay, idGiay, idChieuCaoDeGiay) || (idSize == mangMa[0] && idNsx == mangMa[1] && idMauSac == mangMa[2] && idHangGiay == mangMa[3] && idGiay == mangMa[4] && idChieuCaoDeGiay == mangMa[5]))
                    {
                        bool thongBao = _qlChiTietGiay.Update(new A_DAL.Entities.ChiTietGiay() { Id = idSelect, IdSize = idSize, IdNsx = idNsx, IdMauSac = idMauSac, IdHangGiay = idHangGiay, IdGiay = idGiay, IdChieuCaoDeGiay = idChieuCaoDeGiay, MoTa = moTa, GiaNhap = giaNhap, GiaBan = giaBan, SoLuongTon = soLuongTon });
                        if (thongBao)
                        {
                            _ = MessageBox.Show("Sửa thành công");
                            LoadView();
                        }
                    }
                    else
                    {
                        _ = MessageBox.Show("Mã hóa đơn đã tồn tại");
                    }
                }
                else
                {
                    _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                }
            }
            else
            {
                _ = MessageBox.Show("hãy chọn đối tượng muốn sửa");
            }
        }

        private void _btnXoa_Click(object sender, EventArgs e)
        {
            if (idSelect != defaultId)
            {
                bool thongBao = _qlChiTietGiay.Delete(_qlChiTietGiay.GetAll().Find(c => c.Id == idSelect));
                if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadView();
                }
            }
            else
            {
                _ = MessageBox.Show("hãy chọn đối tượng muốn xóa");
            }
        }

        private void _lsvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView? lsv = sender as ListView;
            if (lsv.SelectedItems.Count > 0)
            {
                idSelect = new Guid(lsv.SelectedItems[0].Text);
                _cbxMauSac.SelectedItem = lsv.SelectedItems[0].SubItems[1].Text;
                _cbxNsx.SelectedItem = lsv.SelectedItems[0].SubItems[2].Text;
                _cbxSize.SelectedItem = lsv.SelectedItems[0].SubItems[3].Text;
                _cbxHangGiay.SelectedItem = lsv.SelectedItems[0].SubItems[4].Text;
                _cbxChieuCaoDeGiay.SelectedItem = lsv.SelectedItems[0].SubItems[5].Text;
                _cbxGiay.SelectedItem = lsv.SelectedItems[0].SubItems[6].Text;
                _tbxMoTa.Texts = lsv.SelectedItems[0].SubItems[7].Text;
                _tbxGiaNhap.Texts = lsv.SelectedItems[0].SubItems[8].Text;
                _tbxGiaBan.Texts = lsv.SelectedItems[0].SubItems[9].Text;
                _tbxSoLuongTon.Texts = lsv.SelectedItems[0].SubItems[10].Text;
                Guid idSize = _qlSize.GetByMa(_cbxSize.SelectedItem.ToString()).Id;
                Guid idNsx = _qlNsx.GetByMa(_cbxNsx.SelectedItem.ToString()).Id;
                Guid idMauSac = _qlMauSac.GetByMa(_cbxMauSac.SelectedItem.ToString()).Id;
                Guid idHangGiay = _qlHangGiay.GetByMa(_cbxHangGiay.SelectedItem.ToString()).Id;
                Guid idGiay = _qlGiay.GetByMa(_cbxGiay.SelectedItem.ToString()).Id;
                Guid idChieuCaoDeGiay = _qlChieuCaoDeGiay.GetByMa(_cbxChieuCaoDeGiay.SelectedItem.ToString()).Id;
                mangMa.Add(idSize);
                mangMa.Add(idNsx);
                mangMa.Add(idMauSac);
                mangMa.Add(idHangGiay);
                mangMa.Add(idGiay);
                mangMa.Add(idChieuCaoDeGiay);
            }
        }
    }
}
