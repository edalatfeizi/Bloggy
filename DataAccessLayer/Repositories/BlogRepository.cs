using DataAccessLayer.Abstraction;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : GenericRepository<Post>, IBlogDal
    {
        private readonly BlogDbContext _context;

        public BlogRepository(BlogDbContext context) : base(context)
        {
            this._context = context;

        }
    }
}
