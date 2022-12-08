﻿using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using C_GUI.QLForm;
using OfficeOpenXml;
using System.Data;
using System.Runtime.InteropServices.ObjectiveC;
using Excel =Microsoft.Office.Interop.Excel;


namespace C_GUI.Views
{
    public partial class FormSanPham : Form
    {
        public string TenMausac;
        public string TenNSX;
        public string TenSize;
        public string TenHangGiay;
        public int KichCo;
        public string TenGiay;
        public string Mota;
        public int GiaNhap;
        public int GiaBan;
        public int SoluongTon;
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
        private Guid Idwhenclick;
        private IQLChiTietTheLoai _Ichotiett;
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
            _Ichotiett = new QLChiTietTheLoai();
            btn_save.Visible = false;   
            LoadData();
            LoadComBo();
            cmb_mausac.SelectedItem="Màu Sắc 1";
            _rjcmbNSX.SelectedItem=1;
            _rjcmbSize.SelectedItem = 1;
            _rjcmbHangGiay.SelectedItem = 1;
            _rjcmbCCDeGiay.SelectedItem = 1;
            _rjcmbTenGiay.SelectedItem = 1;
            cmb_theloai.SelectedItem = 1;
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadComBo()
        {
            cmb_mausac.Items.Clear();
            foreach (var mauSac in _MauSac.GetAll())
            {
                cmb_mausac.Items.Add(mauSac.TenMauSac);
            }
            _rjcmbNSX.Items.Clear();
            foreach (var nsx in _Nsx.GetAll())
            {
                _rjcmbNSX.Items.Add(nsx.TenNsx);
            }
            _rjcmbSize.Items.Clear();
            foreach (var siz in _Size.GetAll())
            {
                _rjcmbSize.Items.Add(siz.TenSize);
            }
            _rjcmbHangGiay.Items.Clear();
            foreach (var hangGiay in _hangGiay.GetAll())
            {
                _rjcmbHangGiay.Items.Add(hangGiay.TenHangGiay);
            }
            _rjcmbCCDeGiay.Items.Clear();
            foreach (var chieuCaoDeGiay in _ChieuCaoDeGiay.GetAll())
            {
                _rjcmbCCDeGiay.Items.Add(chieuCaoDeGiay.KichCo);
            }
            _rjcmbTenGiay.Items.Clear();
            foreach (var VARIABLE in _Giay.GetAll())
            {
                _rjcmbTenGiay.Items.Add(VARIABLE.TenGiay);
            }
            cmb_theloai.Items.Clear();
            foreach (var a in _theloai.GetAll())
            {
                cmb_theloai.Items.Add(a.MaTheLoai);
            }
            
        }

        public void LoadData()
        {
            _dgrvThongTinSanPham.ColumnCount = 11;
            _dgrvThongTinSanPham.Columns[0].Name = "ID";
            _dgrvThongTinSanPham.Columns[0].Visible=false;
            _dgrvThongTinSanPham.Columns[1].Name="Tên Màu Sắc";
            _dgrvThongTinSanPham.Columns[2].Name = "Tên Nhà Sản Xuất";
            _dgrvThongTinSanPham.Columns[3].Name = "Tên Size";
            _dgrvThongTinSanPham.Columns[4].Name = "Tên hãng Giày";
            _dgrvThongTinSanPham.Columns[5].Name = " Kich Co";
            _dgrvThongTinSanPham.Columns[6].Name = "Tên giày";
            _dgrvThongTinSanPham.Columns[7].Name = "Mô Tả ";
            _dgrvThongTinSanPham.Columns[8].Name = "Gia Bán";
            _dgrvThongTinSanPham.Columns[9].Name = "Giá Nhập";
            _dgrvThongTinSanPham.Columns[10].Name = "Số Lương Tồn";
            _dgrvThongTinSanPham.Rows.Clear();
            
            foreach (var VARIABLE in _ChiTietGiay.GetAllView())
            {
                _dgrvThongTinSanPham.Rows.Add(VARIABLE.ChiTietGiay.Id, VARIABLE.MauSac.TenMauSac,VARIABLE.Nsx.TenNsx,VARIABLE.Size.TenSize,VARIABLE.HangGiay.TenHangGiay,VARIABLE.ChieuCaoDeGiay.KichCo,VARIABLE.Giay.TenGiay,VARIABLE.ChiTietGiay.MoTa,VARIABLE.ChiTietGiay.GiaBan,VARIABLE.ChiTietGiay.GiaNhap,VARIABLE.ChiTietGiay.SoLuongTon);
            }
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            LoadComBo();
            c.ShowDialog();
           
            
        }

        private void btn_size_Click(object sender, EventArgs e)
        {
            
            size.ShowDialog();
            LoadComBo();
        }

        private void Btn_hanggiay_Click(object sender, EventArgs e)
        {
            
            HangGiay.ShowDialog();
            LoadComBo();
        }

        private void btn_chieuCaodegiay_Click(object sender, EventArgs e)
        {
            
            ChieuCaoDeGiay.ShowDialog();
            LoadComBo();
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            
            MauSac.ShowDialog();
            LoadComBo();
        }

        private void btn_theloai_Click(object sender, EventArgs e)
        {
           
            TheLoai.ShowDialog();
            LoadComBo();
        }

        private void btn_giay_Click(object sender, EventArgs e)
        {
            Giay.ShowDialog();
            LoadComBo();
        }

        private void _rjbtnRemove_Click(object sender, EventArgs e)
        {
            var xoa = _ChiTietGiay.GetAll().FirstOrDefault(c => c.Id == Idwhenclick);
            var a = MessageBox.Show("Thông Báo", "Bạn Có Muốn Sửa Không", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {

                if (_ChiTietGiay.Delete(xoa))
                {
                    MessageBox.Show("Xóa Thành Công");
                    LoadData();
                }
            }
        }

        private void _rjbtnAdd_Click(object sender, EventArgs e)
        {

            var hoi = MessageBox.Show(" Thông Báo", "Bạn có Muốn thêm ko", MessageBoxButtons.YesNo);
            if (_rjcmbHangGiay.Texts == "" || _rjcmbCCDeGiay.Texts == "" || _rjcmbNSX.Texts == "" ||
                _rjcmbSize.Texts == "" || _rjcmbSize.Texts == "" || _rjtbxSoLuongTon.Texts == "" ||
                _rjtbxGiaNhap.Texts == "" || _rjtbxGiaBan.Texts == "" || _rjtbxSoLuongTon.Texts == "")
            {
                MessageBox.Show("bạn Đang điền thiếu vui lòng điền lại");
            }
            else
            {
                var mausac = _MauSac.GetAll().FirstOrDefault(c => c.TenMauSac == cmb_mausac.Texts);
                var nsx = _Nsx.GetAll().FirstOrDefault(c => c.TenNsx == _rjcmbNSX.Texts);
                var hanggiay = _hangGiay.GetAll().FirstOrDefault(c => c.TenHangGiay == _rjcmbHangGiay.Texts);
                var size = _Size.GetAll().FirstOrDefault(c => c.TenSize == _rjcmbSize.Texts);
                var giay = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == _rjcmbTenGiay.Texts);
                var ccDeGiay = _ChieuCaoDeGiay.GetAll().FirstOrDefault(c => c.KichCo == int.Parse(_rjcmbCCDeGiay.Texts));
                bool thongbao = _ChiTietGiay.Add(new ChiTietGiay()
                {
                    Id = Guid.NewGuid(),
                    IdMauSac = mausac.Id,
                    IdNsx = nsx.Id,
                    IdSize = size.Id,
                    IdHangGiay = hanggiay.Id,
                    IdChieuCaoDeGiay = ccDeGiay.Id,
                    IdGiay = giay.Id,
                    MoTa = _rtbxMota.Text,
                    GiaBan = int.Parse(_rjtbxGiaBan.Texts),
                    GiaNhap = int.Parse(_rjtbxGiaNhap.Texts),
                    SoLuongTon = int.Parse(_rjtbxSoLuongTon.Texts),
                    TrangThai = 1
                });

                if (hoi == DialogResult.Yes)
                {
                    if (thongbao)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
            }
        }

        private void _dgrvThongTinSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Idwhenclick = Guid.Parse(_dgrvThongTinSanPham.CurrentRow.Cells[0].Value.ToString());
            cmb_mausac.SelectedItem = _dgrvThongTinSanPham.CurrentRow.Cells[1].Value.ToString();
            _rjcmbNSX.SelectedItem = _dgrvThongTinSanPham.CurrentRow.Cells[2].Value.ToString();
            _rjcmbSize.SelectedItem = _dgrvThongTinSanPham.CurrentRow.Cells[3].Value.ToString();
            _rjcmbHangGiay.SelectedItem = _dgrvThongTinSanPham.CurrentRow.Cells[4].Value.ToString();
            _rjcmbCCDeGiay.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[5].Value.ToString();
            _rjcmbTenGiay.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[6].Value.ToString();
            _rtbxMota.Text = _dgrvThongTinSanPham.CurrentRow.Cells[7].Value.ToString();
            _rjtbxGiaBan.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[8].Value.ToString();
            _rjtbxGiaNhap.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[9].Value.ToString();
            _rjtbxSoLuongTon.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[10].Value.ToString();
        }

        private void _rjbtnEdit_Click(object sender, EventArgs e)
        {
            var mausac = _MauSac.GetAll().FirstOrDefault(c => c.TenMauSac == cmb_mausac.Texts);
            var nsx = _Nsx.GetAll().FirstOrDefault(c => c.TenNsx == _rjcmbNSX.Texts);
            var hanggiay = _hangGiay.GetAll().FirstOrDefault(c => c.TenHangGiay == _rjcmbHangGiay.Texts);
            var size = _Size.GetAll().FirstOrDefault(c => c.TenSize == _rjcmbSize.Texts);
            var giay = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == _rjcmbTenGiay.Texts);
            var ccDeGiay = _ChieuCaoDeGiay.GetAll().FirstOrDefault(c => c.KichCo == int.Parse(_rjcmbCCDeGiay.Texts));
            bool thongbao = _ChiTietGiay.Update(new ChiTietGiay()
            {
                Id = Idwhenclick,
                IdMauSac = mausac.Id,
                IdNsx = nsx.Id,
                IdSize = size.Id,
                IdHangGiay = hanggiay.Id,
                IdChieuCaoDeGiay = ccDeGiay.Id,
                IdGiay = giay.Id,
                MoTa = _rtbxMota.Text,
                GiaBan = int.Parse(_rjtbxGiaBan.Texts),
                GiaNhap = int.Parse(_rjtbxGiaNhap.Texts),
                SoLuongTon = int.Parse(_rjtbxSoLuongTon.Texts),
                TrangThai = 1
            });
            var hoi = MessageBox.Show(" Thông Báo", "Bạn có Muốn Sửa ko", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (thongbao)
                {
                    MessageBox.Show("Sửa Thành Công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            FormImport vn = new FormImport();
            vn.ShowDialog();
            //    var a = MessageBox.Show("Bạn có muốn chọn Nguồn Excel Ko", "Thông Báo", MessageBoxButtons.YesNo);
            //    if (a ==DialogResult.Yes)
            //    {


            //        OpenFileDialog openFileDialog = new OpenFileDialog();
            //        openFileDialog.FileName = btn_link.Text;
            //        openFileDialog.Filter = "Excel Spreadsheet (*.XLSX;*.XLSM)|*.XLSX;*.XLSM";
            //        if (openFileDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            btn_link.Text = openFileDialog.FileName;
            //        }

            //        DataTable dt = new DataTable();

            //        dt.Columns.Add("Tên Màu Sắc");
            //        dt.Columns.Add("Tên NSX");
            //        dt.Columns.Add("Tên Size");
            //        dt.Columns.Add("Hãng Giày");
            //        dt.Columns.Add("Kích Cỡ");
            //        dt.Columns.Add("Tên Giày");
            //        dt.Columns.Add("Mô Tả");
            //        dt.Columns.Add("Giá Nhập");
            //        dt.Columns.Add("Giá bán");
            //        dt.Columns.Add("Số Lượng tồn");
            //        dt.Rows.Clear();
            //        try
            //        {
            //            // mo file excel
            //            var package = new ExcelPackage(new FileInfo(btn_link.Text));
            //            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            //            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            //            for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
            //            {
            //                try
            //                {
            //                    int j = 1;
            //                    var tenmausac = worksheet.Cells[i, j++].Value;
            //                    var tennsx = worksheet.Cells[i, j++].Value;
            //                    var namsize = worksheet.Cells[i, j++].Value;
            //                    var hanggiay = worksheet.Cells[i, j++].Value;
            //                    var kichco = worksheet.Cells[i, j++].Value;
            //                    var tengiay = worksheet.Cells[i, j++].Value;
            //                    var mota = worksheet.Cells[i, j++].Value;
            //                    var gianhap = worksheet.Cells[i, j++].Value;
            //                    var giaban = worksheet.Cells[i, j++].Value;
            //                    var soluongton = worksheet.Cells[i, j++].Value;

            //                    dt.Rows.Add(tenmausac, tennsx, namsize, hanggiay, kichco, tengiay, mota, gianhap, giaban,
            //                        soluongton);
            //                }
            //                catch (Exception)
            //                {
            //                    MessageBox.Show("Error");
            //                    throw;
            //                }
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Error");
            //            throw;
            //        }

            //        _dgrvThongTinSanPham.DataSource = dt.DefaultView;
            //    }
            //}
            //private void btn_excel_Click(object sender, EventArgs e)
            //{

            //    DataTable dataTable = new DataTable();
            //    DataColumn col1= new DataColumn("Tên Màu Sắc");
            //    DataColumn col2 = new DataColumn("Tên Nhà Sản Xuất");
            //    DataColumn col3 = new DataColumn("Tên Size");
            //    DataColumn col4 = new DataColumn("Tên Hãng Giày");
            //    DataColumn col5 = new DataColumn("Kích Cỡ");
            //    DataColumn col6 = new DataColumn("Tên Giày");
            //    DataColumn col7 = new DataColumn("Mô tả");
            //    DataColumn col8 = new DataColumn("Giá Bán");
            //    DataColumn col9 = new DataColumn("Giá Nhập");
            //    DataColumn col10 = new DataColumn("Số Lượng Tồn");
            //   dataTable.Columns.Add(col1);
            //   dataTable.Columns.Add(col2);
            //   dataTable.Columns.Add(col3);
            //   dataTable.Columns.Add(col4);
            //   dataTable.Columns.Add(col5);
            //   dataTable.Columns.Add(col6);
            //   dataTable.Columns.Add(col7);
            //   dataTable.Columns.Add(col8);
            //   dataTable.Columns.Add(col9);
            //   dataTable.Columns.Add(col10);
            //   foreach (DataGridViewRow dataGridViewRow in _dgrvThongTinSanPham.Rows)
            //   {
            //       DataRow dtrow = dataTable.NewRow();
            //       dtrow[0] = dataGridViewRow.Cells[0].Value;
            //        dtrow[1] = dataGridViewRow.Cells[1].Value;
            //       dtrow[2] = dataGridViewRow.Cells[2].Value;
            //       dtrow[3] = dataGridViewRow.Cells[3].Value;
            //       dtrow[4] = dataGridViewRow.Cells[4].Value;
            //       dtrow[5] = dataGridViewRow.Cells[5].Value;
            //       dtrow[6] = dataGridViewRow.Cells[6].Value;
            //       dtrow[7] = dataGridViewRow.Cells[7].Value;
            //       dtrow[8] = dataGridViewRow.Cells[8].Value;
            //       dtrow[9] = dataGridViewRow.Cells[9].Value;
            //       dataTable.Rows.Add(dtrow);
            //   }
            //   Export(dataTable,"Danh Sách","Danh Sách Sản Phẩm");  
            //}

            //private void Export(DataTable dataTable, string sheetName, string title)
            //{
            ////Tạo các đối tượng Excel

            //Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            //Microsoft.Office.Interop.Excel.Workbooks oBooks;

            //Microsoft.Office.Interop.Excel.Sheets oSheets;

            //Microsoft.Office.Interop.Excel.Workbook oBook;

            //Microsoft.Office.Interop.Excel.Worksheet oSheet;

            ////Tạo mới một Excel WorkBook 

            //oExcel.Visible = true;

            //oExcel.DisplayAlerts = false;

            //oExcel.Application.SheetsInNewWorkbook = 1;

            //oBooks = oExcel.Workbooks;

            //oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            //oSheets = oBook.Worksheets;

            //oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            //oSheet.Name = sheetName;

            //// Tạo phần Tiêu đề
            //Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            //head.MergeCells = true;

            //head.Value2 = title;

            //head.Font.Bold = true;

            //head.Font.Name = "Times New Roman";

            //head.Font.Size = "20";

            //head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //// Tạo tiêu đề cột 

            //Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            //cl1.Value2 = "Tên Màu Sắc";

            //cl1.ColumnWidth = 12;

            //Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            //cl2.Value2 = "Tên Nhà Sản Xuất";

            //cl2.ColumnWidth = 25.0;

            //Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            //cl3.Value2 = "Tên Size";
            //cl3.ColumnWidth = 12.0;

            //Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            //cl4.Value2 = "Tên Hãng giày";

            //cl4.ColumnWidth = 10.5;

            //Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            //cl5.Value2 = "Kích Cỡ";

            //cl5.ColumnWidth = 20.5;

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            //cl6.Value2 = "Tên Giày";

            //cl6.ColumnWidth = 18.5;

            //Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            //cl7.Value2 = "Mô tả";

            //cl7.ColumnWidth = 13.5;
            //Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            //cl8.Value2 = "Giá Bán";

            //cl8.ColumnWidth = 13.5;
            //Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            //cl9.Value2 = "Giá Nhập";

            //cl9.ColumnWidth = 13.5;
            //Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            //cl10.Value2 = "Số Lượng Tồn";

            //cl10.ColumnWidth = 13.5;

            //Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");

            //rowHead.Font.Bold = true;

            //// Kẻ viền

            //rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //// Thiết lập màu nền

            //rowHead.Interior.ColorIndex = 6;

            //rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //// Tạo mảng theo datatable

            //object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            ////Chuyển dữ liệu từ DataTable vào mảng đối tượng

            //for (int row = 0; row < dataTable.Rows.Count; row++)
            //{
            //    DataRow dataRow = dataTable.Rows[row];

            //    for (int col = 0; col < dataTable.Columns.Count; col++)
            //    {
            //        arr[row, col] = dataRow[col];
            //    }
            //}

            ////Thiết lập vùng điền dữ liệu

            //int rowStart = 4;

            //int columnStart = 1;

            //int rowEnd = rowStart + dataTable.Rows.Count - 2;

            //int columnEnd = dataTable.Columns.Count;

            //// Ô bắt đầu điền dữ liệu

            //Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            //// Ô kết thúc điền dữ liệu

            //Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            //// Lấy về vùng điền dữ liệu

            //Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            ////Điền dữ liệu vào vùng đã thiết lập

            //range.Value2 = arr;

            //// Kẻ viền

            //range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //// Căn giữa cột mã nhân viên

            ////Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            ////Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            ////Căn giữa cả bảng 
            //oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //}
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            

            var thongbao = MessageBox.Show("bạn có muốn lưu Không ", "thông báo", MessageBoxButtons.YesNo);
            if (thongbao == DialogResult.Yes)
            {
                for (int i = 0; i < _dgrvThongTinSanPham.Rows.Count; i++)
                {
                    TenMausac = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[0].Value);
                    TenNSX = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[1].Value);
                    TenSize = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[2].Value);
                    TenHangGiay= Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[3].Value);
                    KichCo = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[4].Value);
                    TenGiay = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[5].Value);
                    Mota = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[6].Value);
                    GiaNhap = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[7].Value);
                    GiaBan= Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[8].Value);
                    SoluongTon = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[9].Value);
                    ;
                }
                


            }
            var idmausac = _MauSac.GetAll().FirstOrDefault(c => c.TenMauSac == TenMausac);
            var idnsx = _Nsx.GetAll().FirstOrDefault(c => c.TenNsx == TenNSX);
            var idsize = _Size.GetAll().FirstOrDefault(c => c.TenSize == TenSize);
            var idhanggiay = _hangGiay.GetAll().FirstOrDefault(c => c.TenHangGiay == TenHangGiay);
            var idkichco = _ChieuCaoDeGiay.GetAll().FirstOrDefault(c => c.KichCo == KichCo);
            var idTenGiay = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == TenGiay);
            var chitsanpham = new ChiTietGiay()
            {
                Id = Guid.NewGuid(),
                IdMauSac = Guid.NewGuid(),
                IdNsx = Guid.NewGuid(),
                IdSize = Guid.NewGuid(),
                IdHangGiay = Guid.NewGuid(),
                IdChieuCaoDeGiay = Guid.NewGuid(),
                IdGiay = Guid.NewGuid(),
                MoTa = Mota,
                GiaNhap = GiaNhap,
                GiaBan = GiaBan,
                SoLuongTon = SoluongTon
            };
            _ChiTietGiay.Add(chitsanpham);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void btn_themtheloai_Click(object sender, EventArgs e)
        {
            var idtheloais = _theloai.GetAll().FirstOrDefault(c => c.MaTheLoai == cmb_theloai.Texts);
            Guid Idchitietgiay = Idwhenclick;
            Guid idtheloai = idtheloais.Id;
            _Ichotiett.Add(new ChiTietTheLoai()
            {
                IdChiTietGiay = Idwhenclick,
                IdTheLoai = idtheloai,
            });
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xuatExcel(saveFileDialog.FileName,_dgrvThongTinSanPham);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công \n " + ex.Message);
                }
            }
        }
        public void xuatExcel(string path, DataGridView _dgrvthongtin)
        {

            try
            {
                if (_dgrvthongtin.Rows.Count > 0)
                {
                    Excel.Application application = new Excel.Application();
                    application.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < _dgrvthongtin.Columns.Count + 1; i++)
                    {
                        application.Cells[1, i] = _dgrvthongtin.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < _dgrvthongtin.Rows.Count; i++)
                    {
                        for (int j = 0; j < _dgrvthongtin.Columns.Count; j++)
                        {
                            application.Cells[i + 2, j + 1] = _dgrvthongtin.Rows[i].Cells[j].Value;
                        }
                    }

                    application.Columns.AutoFit();
                    application.Visible = true;
                    application.ActiveWorkbook.SaveCopyAs(path);
                    application.ActiveWorkbook.Saved = true;
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

        }

        private void _rjtbxGiaNhap__TextChanged(object sender, EventArgs e)
        {
            if (_rjtbxGiaNhap==null)
            {
                MessageBox.Show("Không Được Để Trống");
            }
        }
    }
}
