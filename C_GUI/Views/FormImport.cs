using OfficeOpenXml;
using System.Data;

namespace C_GUI.Views
{
    public partial class FormImport : Form
    {
        public FormImport()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn chọn Nguồn Excel Ko", "Thông Báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {


                OpenFileDialog openFileDialog = new()
                {
                    FileName = btn_link.Text,
                    Filter = "Excel Spreadsheet (*.XLSX;*.XLSM)|*.XLSX;*.XLSM"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btn_link.Text = openFileDialog.FileName;
                }

                DataTable dt = new();

                _ = dt.Columns.Add("Tên Màu Sắc");
                _ = dt.Columns.Add("Tên NSX");
                _ = dt.Columns.Add("Tên Size");
                _ = dt.Columns.Add("Hãng Giày");
                _ = dt.Columns.Add("Kích Cỡ");
                _ = dt.Columns.Add("Tên Giày");
                _ = dt.Columns.Add("Mô Tả");
                _ = dt.Columns.Add("Giá Nhập");
                _ = dt.Columns.Add("Giá bán");
                _ = dt.Columns.Add("Số Lượng tồn");
                dt.Rows.Clear();
                try
                {
                    // mo file excel
                    ExcelPackage package = new(new FileInfo(btn_link.Text));
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            int j = 1;
                            object tenmausac = worksheet.Cells[i, j++].Value;
                            object tennsx = worksheet.Cells[i, j++].Value;
                            object namsize = worksheet.Cells[i, j++].Value;
                            object hanggiay = worksheet.Cells[i, j++].Value;
                            object kichco = worksheet.Cells[i, j++].Value;
                            object tengiay = worksheet.Cells[i, j++].Value;
                            object mota = worksheet.Cells[i, j++].Value;
                            object gianhap = worksheet.Cells[i, j++].Value;
                            object giaban = worksheet.Cells[i, j++].Value;
                            object soluongton = worksheet.Cells[i, j++].Value;

                            _ = dt.Rows.Add(tenmausac, tennsx, namsize, hanggiay, kichco, tengiay, mota, gianhap, giaban,
                                soluongton);
                        }
                        catch (Exception)
                        {
                            _ = MessageBox.Show("Error");
                            throw;
                        }
                    }
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Error");
                    throw;
                }

                _dgrvThongTinSanPham.DataSource = dt.DefaultView;
            }
        }
    }
}

