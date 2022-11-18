using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLDiemTieuDung
    {
        bool Add(DiemTieuDung obj);
        bool Update(DiemTieuDung obj);
        bool Delete(DiemTieuDung obj);
        List<DiemTieuDung> GetAll();
        DiemTieuDung? GetByMa(string? ma);

        bool CheckMa(string ma);
        List<DiemTieuDungView> GetAllView();
    }
}
