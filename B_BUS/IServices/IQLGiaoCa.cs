using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLGiaoCa
    {
        bool Add(GiaoCa obj);
        bool Update(GiaoCa obj);
        bool Delete(GiaoCa obj);
        List<GiaoCaView> GetAllView();
    }
}
