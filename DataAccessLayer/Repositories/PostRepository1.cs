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
    public class PostRepository1 : GenericRepository<Post>, IPostRepository
    {
        private readonly BlogDbContext _context;

        public PostRepository1(BlogDbContext context) : base(context)
        {
            this._context = context;

        }
    }
}
