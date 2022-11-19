namespace A_DAL.Entities
{
    public class PhuongThucThanhToan
    {
        public PhuongThucThanhToan()
        {
            ChiTietThanhToans = new HashSet<ChiTietThanhToan>();
        }
        public Guid Id { get; set; }
        public string MaPhuongThucThanhToan { get; set; } = null!;
        public string TenPhuongThucThanhToan { get; set; } = null!;
        public ICollection<ChiTietThanhToan> ChiTietThanhToans { get; set; }
    }
}
