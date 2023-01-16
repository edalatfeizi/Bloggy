using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;

        public CategoryController(ICategoryService categoryManager)
        {
            this._categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            var categories = _categoryManager.GetList();
            return View(categories);
        }
    }
}
