using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLHoaDonChiTiet
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        bool Delete(HoaDonChiTiet obj);
        List<HoaDonChiTiet> GetAll();
        bool CheckMa(Guid idHoaDon, Guid idChiTietGiay);
        List<HoaDonChiTietView> GetAllView();
    }
}
