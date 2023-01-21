

using DataAccessLayer.Abstraction;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(BlogDbContext context) : base(context)
        {
        }

        public async Task<List<Post>> GetPostListWithCategoryAsync(CancellationToken cancellationToken)
        {
            using (var c = _context)
            {
                var posts = await c.Set<Post>().Include(p => p.Categories).ToListAsync(cancellationToken);
                return posts;
            }
        }
    }
}
