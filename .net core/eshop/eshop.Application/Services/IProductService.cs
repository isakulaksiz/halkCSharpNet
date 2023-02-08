using eshop.Entities;

namespace eshop.Application.Services
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();
    }
}