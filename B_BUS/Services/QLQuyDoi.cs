using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLQuyDoi : IQLQuyDoi
    {
        //bien
        public IGenericRepository<QuyDoi> igQuyDoi;

        public QLQuyDoi()
        {
            igQuyDoi = new GenericRepository<QuyDoi>();
        }
        public bool Add(QuyDoi obj)
        {
            //add
            return igQuyDoi.Add(obj);
        }

        public bool Update(QuyDoi obj)
        {
            //update
            return igQuyDoi.Update(obj);
        }

        public bool Delete(QuyDoi obj)
        {
            //delete
            return igQuyDoi.Delete(obj);
        }

        public List<QuyDoi> GetAll()
        {
            //GetAll
            return igQuyDoi.GetAll();
        }

        public QuyDoi? GetByMa(string? ma)
        {
            //GetByMa
            return igQuyDoi.GetAll().Find(c => c.MaQuyDoi == ma);
        }

        public bool CheckMa(string ma)
        {
            //checkma

            return !igQuyDoi.GetAll().Any(c => c.MaQuyDoi == ma);
        }

        public List<QuyDoiView> GetAllView()
        {
            // getall
            List<QuyDoiView> lst = (from a in igQuyDoi.GetAll()
                                    select new QuyDoiView()
                                    {
                                        QuyDoi = a,
                                    }).ToList();
            return lst;
        }
    }
}
