using DataAccessLayer.Abstraction;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        private readonly BlogDbContext _context; 
        public CategoryRepository(BlogDbContext context) : base(context)
        { 
            this._context = context;
        }
       
    }
}
