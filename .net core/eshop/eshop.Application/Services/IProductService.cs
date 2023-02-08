using eshop.Entities;

namespace eshop.Application.Services
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();
        IList<Product> GetProductsByCategoryId(int categoryId);
    }
}