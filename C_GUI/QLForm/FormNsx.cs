using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormNsx : Form
    {
        public IQLNsx _iQLNsx;
        private Guid _ID;
        public FormNsx()
        {
            _iQLNsx = new QLNsx();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_show.ColumnCount = 6;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "ma";
            dgrid_show.Columns[3].Name = "ten";
            dgrid_show.Columns[4].Name = "dia chi";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = true;
            foreach (var a in _iQLNsx.GetAllView())
            {
                dgrid_show.Rows.Add(stt++, a.Nsx.Id, a.Nsx.MaNsx, a.Nsx.TenNsx, a.Nsx.DiaChi);
            }
        }

        private void FormNsx_Load(object sender, EventArgs e)
        {

        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
            txt_diachi.Texts = dgrid_show.Rows[index].Cells[4].Value.ToString();
        }
        public Nsx GetCtrlValues()
        {
            return new Nsx()
            {
                MaNsx = txt_ma.Texts,
                TenNsx = txt_ten.Texts,
                DiaChi = txt_diachi.Texts,
            };
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _iQLNsx.Add(GetCtrlValues());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool thongBao = _iQLNsx.Update(new A_DAL.Entities.Nsx() { Id = _ID, MaNsx = txt_ma.Texts, TenNsx = txt_ten.Texts, DiaChi = txt_diachi.Texts });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _iQLNsx.Delete(_iQLNsx.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }
}
