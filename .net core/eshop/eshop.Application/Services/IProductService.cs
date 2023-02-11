using eshop.Entities;

namespace eshop.Application.Services
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();
        IList<Product> GetProductsByCategoryId(int categoryId);
        Product GetProduct(int id);

        int CreateProduct(Product product);
        bool IsExists(int id);
        void UpdateProduct(Product product);
        IList<Product> SearchProductByName(string name);
        void DeleteProduct(int id);
    }
}