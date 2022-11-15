using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class NhanVienView
    {
        public NhanVien NhanVien { get; set; } = new();
        public ChucVu ChucVu { get; set; } = new();
        public CuaHang CuaHang { get; set; } = new();
    }
}
