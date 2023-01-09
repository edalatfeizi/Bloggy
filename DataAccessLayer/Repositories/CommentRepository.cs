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
        private readonly Context _context;

        public CommentRepository(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
