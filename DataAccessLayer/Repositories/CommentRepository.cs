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
    public class CommentRepository : GenericRepository<Comment>, ICommentDal
    {
        private readonly BlogDbContext _context;

        public CommentRepository(BlogDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
