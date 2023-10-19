using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IServiceManager _repositoryManager;

        public CategoryController(IServiceManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IActionResult Index()
        {
            return View(_repositoryManager.CategoryService.GetAllCategories(false));
        }
    }
}