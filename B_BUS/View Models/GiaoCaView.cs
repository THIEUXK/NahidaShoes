using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class GiaoCaView
    {
        public GiaoCa GiaoCa { get; set; } = new();
        public NhanVien NhanVien { get; set; } = new();

    }
}
