using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQlLichSuDiemTieuDung
    {
        bool Add(LichSuDiemTieuDung obj);
        bool Update(LichSuDiemTieuDung obj);
        bool Delete(LichSuDiemTieuDung obj);
        List<LichSuDiemTieuDungView> GetAllView();
    }
}
