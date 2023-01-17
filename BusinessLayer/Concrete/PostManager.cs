using BusinessLayer.Abstract;
using DataAccessLayer.Abstraction;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PostManager : IPostService
    {
        private readonly IPostRepository _post_repository;

        public PostManager(IPostRepository postRepository)
        {
            this._post_repository = postRepository;
        }
        public void Add(Post post)
        {
            _post_repository.Insert(post);
        }

        public Post GetById(int id)
        {
            return _post_repository.GetById(id);
        }

        public List<Post> GetList()
        {
            return _post_repository.GetListAll();
        }

        public void Remove(Post post)
        {
            _post_repository.Delete(post);
        }

        public void Update(Post post)
        {
            _post_repository.Update(post);
        }
    }
}
