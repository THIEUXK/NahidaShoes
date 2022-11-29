using B_BUS.IServices;
using B_BUS.Services;
using C_GUI.QLForm;

namespace C_GUI.Views
{
    public partial class FormSanPham : Form
    {
        
        private FormNsx c;
        private FormSize size;
        private FormHangGiay HangGiay;
        FormChieuCaoDeGiay ChieuCaoDeGiay;
        private FormMauSac MauSac;
        private IQLChiTietGiay _ChiTietGiay;
        private IQLMauSac _MauSac;
        IQLNsx _Nsx;
        private IQLSize _Size;
        private IQLHangGiay _hangGiay;
        IQLChieuCaoDeGiay _ChieuCaoDeGiay;
        private IQLGiay _Giay;
        private IQLChiTietTheLoai _ChiTietTheLoai;
        private IQLTheLoai _theloai;
        private FormTheLoai TheLoai;
        private FormGiay Giay;
        public FormSanPham()
        {
            InitializeComponent();
            _ChiTietGiay = new QLChiTietGiay();
            _MauSac = new QLMauSac();
            _Nsx = new QLNsx();
            _Size = new QLSize();
            _hangGiay = new QLHangGiay();
            _ChieuCaoDeGiay = new QLChieuCaoDeGiay();
            _Giay = new QLGiay();
            _ChiTietTheLoai = new QLChiTietTheLoai();
            _theloai = new QLTheLoai();
            c = new FormNsx();
            size = new FormSize();
            HangGiay = new FormHangGiay();
            ChieuCaoDeGiay = new FormChieuCaoDeGiay();
            MauSac = new FormMauSac();
            TheLoai = new FormTheLoai();
            Giay = new FormGiay();
            
                
            LoadData();
            LoadComBo();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadComBo()
        {
            foreach (var mauSac in _MauSac.GetAll())
            {
                cmb_mausac.Items.Add(mauSac.TenMauSac);
            }

            foreach (var nsx in _Nsx.GetAll())
            {
                _rjcmbNSX.Items.Add(nsx.TenNsx);
            }

            foreach (var siz in _Size.GetAll())
            {
                _rjcmbSize.Items.Add(siz.TenSize);
            }

            foreach (var hangGiay in _hangGiay.GetAll())
            {
                _rjcmbHangGiay.Items.Add(hangGiay.TenHangGiay);
            }

            foreach (var chieuCaoDeGiay in _ChieuCaoDeGiay.GetAll())
            {
                _rjcmbCCDeGiay.Items.Add(chieuCaoDeGiay.MaKichCo);
            }

            foreach (var VARIABLE in _Giay.GetAll())
            {
                _rjcmbTenGiay.Items.Add(VARIABLE.TenGiay);
            }

            foreach (var a in _theloai.GetAll())
            {
                cmb_theloai.Items.Add(a.TenTheLoai);
            }
        }

        public void LoadData()
        {
            _dgrvThongTinSanPham.ColumnCount = 20;
            _dgrvThongTinSanPham.Columns[0].Name = "ID";
            _dgrvThongTinSanPham.Columns[0].Visible=false;
            _dgrvThongTinSanPham.Columns[1].Name="Tên Màu Sắc";
            _dgrvThongTinSanPham.Columns[2].Name = "Tên Nhà Sản Xuất";
            _dgrvThongTinSanPham.Columns[3].Name = "Tên Size";
            _dgrvThongTinSanPham.Columns[4].Name = "Tên hãng Giày";
            _dgrvThongTinSanPham.Columns[5].Name = "Ma Kich Co";
            _dgrvThongTinSanPham.Columns[6].Name = "Tên giày";
            _dgrvThongTinSanPham.Columns[7].Name = "Mô Tả ";
            _dgrvThongTinSanPham.Columns[8].Name = "Gia Bán";
            _dgrvThongTinSanPham.Columns[9].Name = "Giá Nhập";
            _dgrvThongTinSanPham.Columns[10].Name = "Số Lương Tồn";
            _dgrvThongTinSanPham.Rows.Clear();
            foreach (var c in _ChiTietGiay.GetAll())
            {
                
            }
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            
            c.ShowDialog();
           
        }

        private void btn_size_Click(object sender, EventArgs e)
        {
            size.ShowDialog();
        }

        private void Btn_hanggiay_Click(object sender, EventArgs e)
        {
            HangGiay.ShowDialog();
        }

        private void btn_chieuCaodegiay_Click(object sender, EventArgs e)
        {
            ChieuCaoDeGiay.ShowDialog();
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            MauSac = new FormMauSac();
        }

        private void btn_theloai_Click(object sender, EventArgs e)
        {
            TheLoai = new FormTheLoai();
        }

        private void btn_giay_Click(object sender, EventArgs e)
        {
            Giay = new FormGiay();
        }

        private void _rjbtnRemove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
