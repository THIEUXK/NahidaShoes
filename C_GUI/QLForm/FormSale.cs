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
using A_DAL.Entities;

namespace C_GUI.QLForm
{
    public partial class FormSale : Form
    {
        public IQLSale _IQlSale;
        Guid _ID;
        public FormSale()
        {
            InitializeComponent();
            _IQlSale = new QLSale();
            LoadData(_IQlSale.GetAllView());
            
        }
        public void LoadData(List<SaleView> saleViews)
        {
            int stt = 1;
            dgrid_show.ColumnCount = 9;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "mã giảm giá";
            dgrid_show.Columns[3].Name = "tên chương trình giảm";
            dgrid_show.Columns[4].Name = "% giảm giá";
            dgrid_show.Columns[5].Name = "số tiền giảm";
            dgrid_show.Columns[6].Name = "ngày bắt đầu";
            dgrid_show.Columns[7].Name = "ngày kết thúc";
            dgrid_show.Columns[8].Name = "trạng thái";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = false;
            foreach (var a in saleViews)
            {
                _ = dgrid_show.Rows.Add(stt++,a.Sale.Id,a.Sale.MaGiamGia,a.Sale.TenChuongTrinh,a.Sale.PhanTramGiamGia,a.Sale.SoTiemGiamGia,a.Sale.NgayBatDau,a.Sale.NgayKetThuc,  a.Sale.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }
        }
        public Sale GetvaluaContro()
        {
            return new Sale()
            {
                MaGiamGia = txt_ma.Texts,
                TenChuongTrinh = txt_ten.Texts,
                PhanTramGiamGia = float.Parse(txt_ptgiam.Texts),
                SoTiemGiamGia = float.Parse(txt_sotiengiam.Texts),
                NgayBatDau = dtp_ngaybatdau.Value,
                NgayKetThuc = dtp_ngayketthuc.Value,
                TrangThai =  0,
            };
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                float giamGia = Convert.ToSingle(txt_ptgiam.Texts);
                float tienKhachDua = Convert.ToSingle(txt_sotiengiam.Texts);
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                _ = _IQlSale.Add(GetvaluaContro());
                LoadData(_IQlSale.GetAllView());
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQlSale.Update(new A_DAL.Entities.Sale() { Id = _ID, MaGiamGia = txt_ma.Texts, TenChuongTrinh = txt_ten.Texts,PhanTramGiamGia = float.Parse(txt_ptgiam.Texts),SoTiemGiamGia = float.Parse(txt_sotiengiam.Texts),NgayBatDau = dtp_ngaybatdau.Value,NgayKetThuc = dtp_ngayketthuc.Value });
                if (thongBao)
                {
                    _ = MessageBox.Show("Sửa thành công");
                    LoadData(_IQlSale.GetAllView());
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQlSale.Delete(_IQlSale.GetAll().Find(c => c.Id == _ID));
                
                    if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadData(_IQlSale.GetAllView());
                }
            }
        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
            txt_ptgiam.Texts = dgrid_show.Rows[index].Cells[4].Value.ToString();
            txt_sotiengiam.Texts = dgrid_show.Rows[index].Cells[5].Value.ToString();
            dtp_ngaybatdau.Value = DateTime.Parse(dgrid_show.Rows[index].Cells[6].Value.ToString());
            dtp_ngayketthuc.Value = DateTime.Parse(dgrid_show.Rows[index].Cells[7].Value.ToString());
            
        }

        private void txt_timkiem__TextChanged(object sender, EventArgs e)
        {
            LoadData(_IQlSale.GetAllView().Where(c => (c.Sale.TenChuongTrinh.ToLower().Contains(txt_timkiem.Texts.ToLower()) || c.Sale.MaGiamGia.ToLower().Contains(txt_timkiem.Texts.ToLower()))).ToList());
        }
    }
}
