using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            var category = _manager.Category.FindAll(trackChanges);

            if (category is null)
                throw new Exception("Category not found!");
            else
                return category;
        }
    }
}