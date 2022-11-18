using A_DAL.Entities;
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
using System.Security.Cryptography;

namespace C_GUI.QLForm
{
    public partial class FormLichsuDiemTiieuDung : Form
    {
        public IQlLichSuDiemTieuDung _IQlLichSuDiemTieuDung;
        public IQLHoaDon _IHoaDon;
        public IQLDiemTieuDung _DiemTieuDung;
        public IQLQuyDoi _IQlQuyDoi;
        Guid _ID;
        public FormLichsuDiemTiieuDung()
        {
            _IQlLichSuDiemTieuDung = new QLLichSuDiemTieuDung();
            _IHoaDon = new QLHoaDon();
            _DiemTieuDung=new QLDiemTieuDung();
            _IQlQuyDoi=new QLQuyDoi();
            InitializeComponent();
            LoadcmbCuaHang();
            LoadData();
            
        }
        public void LoadcmbCuaHang()
        {

            foreach (var a in _IHoaDon.GetAll())
            {
                cmb_hoadon.Items.Add(a.MaHoaDon);
            }
            foreach (var a in _DiemTieuDung.GetAll())
            {
                cmb_diemtieudung.Items.Add(a.SoDiem);
            }
            foreach (var a in _IQlQuyDoi.GetAll())
            {
                cmb_quydoi.Items.Add(a.TiLeQuyDoi);
            }
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_show.ColumnCount = 13;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "maHoaDon";
            dgrid_show.Columns[3].Name = "Điểm tiêu dùng";
            dgrid_show.Columns[4].Name = "Tỉ lệ quy đổi";
            dgrid_show.Columns[5].Name = "gia trị quy đổi";
            dgrid_show.Columns[6].Name = "trang thai";
            dgrid_show.Rows.Clear();
           dgrid_show.Columns[1].Visible = true;
            foreach (var a in _IQlLichSuDiemTieuDung.GetAllView())
            {

                dgrid_show.Rows.Add(stt++, a.LichSuDiemTieuDung.Id, a.HoaDon.MaHoaDon, a.DiemTieuDung.SoDiem, a.QuyDoi.TiLeQuyDoi, a.LichSuDiemTieuDung.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
            }

        }

        public LichSuDiemTieuDung GetvaluaContro()
        {
            var x = _IHoaDon.GetAll().FirstOrDefault(c => c.MaHoaDon == cmb_hoadon.Texts);

            var y = _DiemTieuDung.GetAll().FirstOrDefault(c => c.SoDiem == float.Parse(cmb_diemtieudung.Texts));

            var z = _IQlQuyDoi.GetAll().FirstOrDefault(c => c.TiLeQuyDoi == float.Parse(cmb_quydoi.Texts));
            return new LichSuDiemTieuDung()
            {
                
                IdHoaDon = x.Id,
                IdDiemTieuDung = y.Id,
                IdQuyDoi = z.Id,

                GiaTriQuyDoi = float.Parse(txt_giatriquydoi.Texts),
                TrangThai = (rbtn_hoatdong.Checked == true ? 1 : 0),

            };
        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            //txt_email.Texts = dgrid_shownhanvien.Rows[index].Cells[4].Value.ToString();
           
          
         
            txt_giatriquydoi.Texts = dgrid_show.Rows[index].Cells[5].Value.ToString();
            

            var a = _IQlLichSuDiemTieuDung.GetAll().FirstOrDefault(c => c.Id == _ID);
            cmb_hoadon.SelectedItem =_IQlLichSuDiemTieuDung.GetAllView().FirstOrDefault(c => c.LichSuDiemTieuDung.IdHoaDon== a.IdHoaDon).HoaDon.MaHoaDon;
            cmb_diemtieudung.SelectedItem = _IQlLichSuDiemTieuDung.GetAllView().FirstOrDefault(c => c.LichSuDiemTieuDung.IdDiemTieuDung == a.IdDiemTieuDung).DiemTieuDung.SoDiem;
            cmb_quydoi.SelectedItem = _IQlLichSuDiemTieuDung.GetAllView().FirstOrDefault(c => c.LichSuDiemTieuDung.IdQuyDoi == a.IdQuyDoi).QuyDoi.TiLeQuyDoi;
            


            if ((dgrid_show.Rows[index].Cells[5].Value.ToString()) == "hoat dong")
            {
                rbtn_hoatdong.Checked = true;
            }
            if ((dgrid_show.Rows[index].Cells[5].Value.ToString()) == "khong hoat dong")
            {
                rbtn_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _IQlLichSuDiemTieuDung.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var x = _IHoaDon.GetAll().FirstOrDefault(c => c.MaHoaDon == cmb_hoadon.Texts);

            var y = _DiemTieuDung.GetAll().FirstOrDefault(c => c.SoDiem == float.Parse(cmb_diemtieudung.Texts));

            var z = _IQlQuyDoi.GetAll().FirstOrDefault(c => c.TiLeQuyDoi == float.Parse(cmb_quydoi.Texts));
            bool thongBao = _IQlLichSuDiemTieuDung.Update(new A_DAL.Entities.LichSuDiemTieuDung()
            {
                Id = _ID,
                IdHoaDon = x.Id,
                IdDiemTieuDung = y.Id,
                IdQuyDoi = z.Id,

                GiaTriQuyDoi = float.Parse(txt_giatriquydoi.Texts),
                TrangThai = (rbtn_hoatdong.Checked == true ? 1 : 0),
            });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQlLichSuDiemTieuDung.Delete(_IQlLichSuDiemTieuDung.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }
}
