namespace A_DAL.Entities
{
    public class PhuongThucThanhToan
    {
        public PhuongThucThanhToan()
        {
            ChiTietThanhToans = new HashSet<ChiTietThanhToan>();
        }
        public Guid Id { get; set; }
        public string MaPttt { get; set; } = null!;
        public string TenPttt { get; set; } = null!;
        public ICollection<ChiTietThanhToan> ChiTietThanhToans { get; set; }
    }
}
