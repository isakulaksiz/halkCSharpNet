using eshop.Entities;

namespace eshop.DataAccess
{
    public interface IProductRepository : IRepository<Product>
    {
        IList<Product> SearchProductsByName(string productName);
        IList<Product> GetProductsByCategoryId(int categoryId);
    }
}
