using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLNhanVien
    {
        bool Add(NhanVien obj);
        bool Update(NhanVien obj);
        bool Delete(NhanVien obj);
        List<NhanVien> GetAll();
        NhanVien? GetByMa(string? ma);

        bool CheckMa(string ma);
        List<NhanVienView> GetAllView();
    }
}
