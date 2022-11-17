using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLCuaHang
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        List<CuaHang> GetAll();
        CuaHang? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<CuaHangView> GetAllView();
    }
}
