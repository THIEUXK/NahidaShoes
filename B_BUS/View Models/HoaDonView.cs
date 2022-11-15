using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class HoaDonView
    {
        public HoaDon HoaDon { get; set; } = new();
        public KhachHang KhachHang { get; set; } = new();
        public NhanVien NhanVien { get; set; } = new();
    }
}
