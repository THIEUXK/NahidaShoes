using A_DAL.Context;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private NahidaShoesDbContext _context;
        public GenericRepository()
        {
            _context = new();
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T? GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }
        public bool Add(T obj)
        {
            if (obj == null)
            {
                return false;
            }
            _ = _context.Set<T>().Add(obj);
            Save();
            return true;
        }
        public bool Update(T obj)
        {
            _context = new();
            if (obj == null)
            {
                return false;
            }
            _ = _context.Set<T>().Update(obj);
            Save();
            return true;
        }
        public bool Delete(T obj)
        {
            if (obj == null)
            {
                return false;
            }
            _ = _context.Set<T>().Remove(obj);
            Save();
            return true;
        }
        public void Save()
        {
               _ = _context.SaveChanges();
        }
    }
}
