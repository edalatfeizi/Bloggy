using DataAccessLayer.Abstraction;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            this._context = context;
        }
        public void Delete(T t)
        {
            using(_context)
            {
                _context.Remove(t);
                _context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (_context)
            {
               return _context.Find<T>(id);
                
            }
        }

        public List<T> GetListAll()
        {
           using (_context)
            {
               return _context.Set<T>().ToList();
                
            }
        }

        public void Insert(T t)
        {
            using (_context)
            {
                _context.Add(t);
                _context.SaveChanges();
            }
        }

        public void Update(T t)
        {
            using (_context)
            {
                _context.Update(t);
                _context.SaveChanges();
            }
        }
    }
}
