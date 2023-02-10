using eshop.Entities;

namespace eshop.DataAccess
{
    public interface IProductRepository : IRepository<Product>
    {
        //SOLID'in I'si: Interface Segregation Principle
        IList<Product> SearchProductsByName(string productName);
        IList<Product> GetProductsByCategoryId(int categoryId);

    }
}
