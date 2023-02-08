using eshop.DataAccess;
using eshop.Entities;

namespace eshop.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IList<Category> GetCategories()
        {
            return categoryRepository.GetAll();
        }
    }
}
