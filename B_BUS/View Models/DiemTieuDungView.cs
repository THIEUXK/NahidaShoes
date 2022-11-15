using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class DiemTieuDungView
    {
        public DiemTieuDung DiemTieuDung { get; set; } = new();
        public KhachHang KhachHang { get; set; } = new();

    }
}
