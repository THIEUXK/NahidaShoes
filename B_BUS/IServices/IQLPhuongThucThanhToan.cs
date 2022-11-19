using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLPhuongThucThanhToan
    {
        bool Add(PhuongThucThanhToan obj);
        bool Update(PhuongThucThanhToan obj);
        bool Delete(PhuongThucThanhToan obj);
        List<PhuongThucThanhToanView> GetAllView();
        List<PhuongThucThanhToan> GetAll();
    }
}
