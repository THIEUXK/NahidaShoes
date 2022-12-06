using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

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
            var a = MessageBox.Show("Bạn có muốn chọn Nguồn Excel Ko", "Thông Báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {


                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.FileName = btn_link.Text;
                openFileDialog.Filter = "Excel Spreadsheet (*.XLSX;*.XLSM)|*.XLSX;*.XLSM";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btn_link.Text = openFileDialog.FileName;
                }

                DataTable dt = new DataTable();

                dt.Columns.Add("Tên Màu Sắc");
                dt.Columns.Add("Tên NSX");
                dt.Columns.Add("Tên Size");
                dt.Columns.Add("Hãng Giày");
                dt.Columns.Add("Kích Cỡ");
                dt.Columns.Add("Tên Giày");
                dt.Columns.Add("Mô Tả");
                dt.Columns.Add("Giá Nhập");
                dt.Columns.Add("Giá bán");
                dt.Columns.Add("Số Lượng tồn");
                dt.Rows.Clear();
                try
                {
                    // mo file excel
                    var package = new ExcelPackage(new FileInfo(btn_link.Text));
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            int j = 1;
                            var tenmausac = worksheet.Cells[i, j++].Value;
                            var tennsx = worksheet.Cells[i, j++].Value;
                            var namsize = worksheet.Cells[i, j++].Value;
                            var hanggiay = worksheet.Cells[i, j++].Value;
                            var kichco = worksheet.Cells[i, j++].Value;
                            var tengiay = worksheet.Cells[i, j++].Value;
                            var mota = worksheet.Cells[i, j++].Value;
                            var gianhap = worksheet.Cells[i, j++].Value;
                            var giaban = worksheet.Cells[i, j++].Value;
                            var soluongton = worksheet.Cells[i, j++].Value;

                            dt.Rows.Add(tenmausac, tennsx, namsize, hanggiay, kichco, tengiay, mota, gianhap, giaban,
                                soluongton);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error");
                            throw;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                    throw;
                }

                _dgrvThongTinSanPham.DataSource = dt.DefaultView;
            }
        }
    }
    }

