using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepositoryManager _repositoryManager;

        public CategoryController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IActionResult Index()
        {
            return View(_repositoryManager.Category.FindAll(false));
        }
    }
}