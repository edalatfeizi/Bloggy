using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class PostController : Controller
    {

        private readonly IPostService _postService;
        private readonly ILogger<PostController> _logger;
        private readonly IOptions<AzureSettings> _settings;

		public PostController(IPostService postService, ILogger<PostController> logger, IOptions<AzureSettings> settings)
		{

			_postService = postService ?? throw new ArgumentNullException(nameof(postService));
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_settings = settings;
		}

		public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            List<Post> posts;

            posts = await _postService.GetPostListWithCategoryAsync(cancellationToken);

            return View(posts);
        }
    }
}
