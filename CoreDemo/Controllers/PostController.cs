using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class PostController : Controller
    {

        private readonly IPostService postService;
        private readonly ILogger logger;

        public PostController(IPostService _postService)
        {

            this.postService = _postService;
            //logger = _logger;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            List<Post> posts;

            posts = await postService.GetPostListWithCategoryAsync(cancellationToken);

            return View(posts);
        }
    }
}
