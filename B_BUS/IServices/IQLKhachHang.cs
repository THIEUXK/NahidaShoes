using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLKhachHang
    {
        bool Add(KhachHang obj);
        bool Update(KhachHang obj);
        bool Delete(KhachHang obj);
        List<KhachHang> GetAll();
        KhachHang? GetByMa(string? ma);
        List<KhachHangView> GetAllView();
    }
}
