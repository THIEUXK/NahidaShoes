using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLTheLoai
    {
        bool Add(TheLoai obj);
        bool Update(TheLoai obj);
        bool Delete(TheLoai obj);
        List<TheLoai> GetAll();
        TheLoai? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<TheLoaiView> GetAllView();
    }
}
