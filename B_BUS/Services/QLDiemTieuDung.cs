using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLDiemTieuDung : IQLDiemTieuDung
    {
        //bien
        public IGenericRepository<DiemTieuDung> igDiem;
        //bien
        public IGenericRepository<KhachHang> igKhachHang;
        public QLDiemTieuDung()
        {
            igDiem = new GenericRepository<DiemTieuDung>();
            igKhachHang = new GenericRepository<KhachHang>();
        }
        public bool Add(DiemTieuDung obj)
        {
            //add
            return igDiem.Add(obj);
        }

        public bool Update(DiemTieuDung obj)
        {
            //update
            return igDiem.Update(obj);
        }

        public bool Delete(DiemTieuDung obj)
        {
            //delete
            return igDiem.Delete(obj);
        }

        public List<DiemTieuDung> GetAll()
        {
            //GetAll
            return igDiem.GetAll();
        }

        public DiemTieuDung? GetByMa(string? ma)
        {
            //GetByMa
            return igDiem.GetAll().Find(c => c.MaDiemTieuDung == ma);
        }

        public bool CheckMa(string ma)
        {
            //checkma

            return !igDiem.GetAll().Any(c => c.MaDiemTieuDung == ma);
        }

        public List<DiemTieuDungView> GetAllView()
        {
            // getall
            List<DiemTieuDungView> lst = (from a in igDiem.GetAll()
                                          join b in igKhachHang.GetAll() on a.IdKhachHang equals b.Id
                                          select new DiemTieuDungView()
                                          {
                                              DiemTieuDung = a,
                                              KhachHang = b
                                          }).ToList();
            return lst;
        }
    }
}
