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
using C_GUI.Views;

namespace C_GUI.QLForm
{
    public partial class FormChiTietSale : Form
    {
        private IQLChiTietSale _chiTietSale;
        private IQLSale _QlSale;
        private IQLChiTietGiay _iChiTietGiay;
        private Guid idwwhen;
        public FormChiTietSale()
        
        {
            InitializeComponent();
            _chiTietSale = new QLChiTietSale();
            _QlSale = new QLSale();
            _iChiTietGiay = new QLChiTietGiay();
            Loadcombo();
            LoadData();

        }

        public void Loadcombo()
        {
            foreach (var c in _QlSale.GetAll())
            {
                cmb_tenmagiamgia.Items.Add(c.TenChuongTrinh);
            }

            foreach (var d in _iChiTietGiay.GetAll())
            {
                cmb_tengiay.Items.Add(d.GiaNhap);
            }
        }

        public void LoadData()
        {
            dgrv_show.ColumnCount = 6;
            dgrv_show.Columns[0].Name = "Id";
            dgrv_show.Columns[0].Visible = false;
            dgrv_show.Columns[1].Name = "Chương Trình Giảm Giá";
            dgrv_show.Columns[2].Name = "Giá Bán";
            dgrv_show.Columns[3].Name = "Trạng Thái";
            dgrv_show.Rows.Clear();
            foreach (var c in _chiTietSale.GetAllView())
            {
                dgrv_show.Rows.Add(c.ChiTietSale.Id, c.Sale.TenChuongTrinh, c.ChiTietGiay.GiaNhap,c.ChiTietSale.TrangThai==1?"Hoạt Động":"Không Hoạt Động");
            }
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x =_QlSale.GetAllView().FirstOrDefault(c => c.Sale.TenChuongTrinh == cmb_tenmagiamgia.Texts)
                ;
            var y = _iChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.GiaNhap == int.Parse(cmb_tengiay.Texts));
            if (_chiTietSale.Add(new ChiTietSale()
                {
                    Id = Guid.NewGuid(),
                    IdSale = x.Sale.Id,
                    IdChiTietGiay = y.ChiTietGiay.Id,
                    TrangThai = rdtn_hoatdong.Checked == true ? 1 : 0
                }))
            {
                MessageBox.Show("Thêm tHành công");
                LoadData();
            }
            else
            {
                MessageBox.Show(" thêm Thất Bại");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var x = _QlSale.GetAllView().FirstOrDefault(c => c.Sale.TenChuongTrinh == cmb_tenmagiamgia.Texts)
                ;
            var y = _iChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.GiaNhap == int.Parse(cmb_tengiay.Texts));
            if (_chiTietSale.Update(new ChiTietSale()
                {
                    Id = idwwhen,
                    IdSale = x.Sale.Id,
                    IdChiTietGiay = y.ChiTietGiay.Id,
                    TrangThai = rdtn_hoatdong.Checked == true ? 1 : 0
                }))
            {
                MessageBox.Show("Sửa tHành công");
                LoadData();
            }
            else
            {
                MessageBox.Show(" Sửa Thất Bại");
            }

        }

        private void dgrv_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index= e.RowIndex;
            idwwhen = Guid.Parse(dgrv_show.Rows[index].Cells[0].Value.ToString());
            var a= _chiTietSale.GetAllView().FirstOrDefault(c => c.ChiTietSale.Id == idwwhen).ChiTietSale;
            cmb_tenmagiamgia.SelectedItem = _chiTietSale.GetAllView().FirstOrDefault(c => c.ChiTietSale.IdSale == a.IdSale).Sale.TenChuongTrinh;
            cmb_tengiay.SelectedItem = _chiTietSale.GetAllView().FirstOrDefault(c => c.ChiTietSale.IdChiTietGiay == a.IdChiTietGiay).ChiTietGiay.GiaNhap;
            if (dgrv_show.Rows[index].Cells[3].Value.ToString()=="Hoạt Động")
            {
                rdtn_hoatdong.Checked=true;
                rdtn_khonghoatdong.Checked = false;
            }
            if(dgrv_show.Rows[index].Cells[3].Value.ToString() == " Không Hoạt Động")
            {
                rdtn_khonghoatdong.Checked = true ;
                rdtn_hoatdong.Checked = false ;
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
          var  thongbao= _chiTietSale.Delete(_chiTietSale.Getall().Find(c => c.Id == idwwhen));
          if (thongbao)
          {
              MessageBox.Show("Xóa THành công");
          }

          MessageBox.Show("Xóa Thất Bại");
        }
    }
}
