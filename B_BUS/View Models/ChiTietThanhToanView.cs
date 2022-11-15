using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class ChiTietThanhToanView
    {
        public ChiTietThanhToan ChiTietThanhToan { get; set; } = new();
        public PhuongThucThanhToan PhuongThucThanhToan { get; set; } = new();
        public HoaDon HoaDon { get; set; } = new();

    }
}
