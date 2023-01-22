using BusinessLayer.Abstract;
using DataAccessLayer.Abstraction;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            this._postRepository = postRepository;
        }
        public void Add(Post post)
        {
            _postRepository.Insert(post);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetById(id);
        }

        public List<Post> GetList()
        {
            return _postRepository.GetListAll();
        }

        public Task<List<Post>> GetPostListWithCategoryAsync(CancellationToken cancellationToken)
        {
            return _postRepository.GetPostListWithCategoryAsync(cancellationToken);
        }

        public void Remove(Post post)
        {
            _postRepository.Delete(post);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
