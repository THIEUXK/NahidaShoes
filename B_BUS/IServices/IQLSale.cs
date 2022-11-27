using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLSale
    {
        bool Add(Sale obj);
        bool Update(Sale obj);
        bool Delete(Sale obj);
        List<Sale> GetAll();
        Sale? GetByMa(string? ma);

        bool CheckMa(string ma);
        List<SaleView> GetAllView();
    }
}
