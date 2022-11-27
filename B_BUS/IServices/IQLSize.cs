using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLSize
    {
        bool Add(Size obj);
        bool Update(Size obj);
        bool Delete(Size obj);
        List<Size> GetAll();
        Size? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<SizeView> GetAllView();
    }
}
