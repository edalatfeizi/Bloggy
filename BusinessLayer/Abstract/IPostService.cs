using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPostService
    {
        void Add(Post post);
        void Remove(Post post);
        void Update(Post post);
        List<Post> GetList();
        Task<List<Post>> GetPostListWithCategoryAsync(CancellationToken cancellationToken);
        Post GetById(int id);
    }
}
