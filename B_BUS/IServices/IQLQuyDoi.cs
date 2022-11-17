using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLQuyDoi
    {
        bool Add(QuyDoi obj);
        bool Update(QuyDoi obj);
        bool Delete(QuyDoi obj);
        List<QuyDoi> GetAll();
        QuyDoi? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<QuyDoiView> GetAllView();
    }
}
