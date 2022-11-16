using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLSize : IQLSize
    {
        //bien
        public IGenericRepository<Size> igSize;

        public QLSize()
        {
            igSize = new GenericRepository<Size>();
        }
        public bool Add(Size obj)
        {
            //add
            return igSize.Add(obj);
        }

        public bool Update(Size obj)
        {
            //update
            return igSize.Update(obj);
        }

        public bool Delete(Size obj)
        {
            //delete
            return igSize.Delete(obj);
        }

        public List<Size> GetAll()
        {
            return igSize.GetAll();
        }

        public Size? GetByMa(string? ma)
        {
            return igSize.GetAll().Find(c => c.MaSize == ma);
        }

        public bool CheckMa(string ma)
        {
            return !igSize.GetAll().Any(c => c.MaSize == ma);
        }

        public List<SizeView> GetAllView()
        {
            // getall
            List<SizeView> lst = (from a in igSize.GetAll()
                                  select new SizeView()
                                  {
                                      Size = a,
                                  }).ToList();
            return lst;
        }
    }
}
