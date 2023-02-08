using eshop.Entities;

namespace eshop.Application.Services
{
    public interface ICategoryService
    {
        IList<Category> GetCategories();
    }
}
