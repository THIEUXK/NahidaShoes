using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLHoaDon
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);
        List<HoaDon> GetAll();
        HoaDon? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<HoaDonView> GetAllView();
    }
}
