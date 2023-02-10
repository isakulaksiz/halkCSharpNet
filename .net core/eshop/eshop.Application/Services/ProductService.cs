using eshop.DataAccess;
using eshop.Entities;

namespace eshop.Application.Services
{
    public class ProductService : IProductService
    {
        //Presentation (MVC)'dan gelen talebi işle ve DataAccess'e ilet.
        //SOLID'in D'si: Dependency Inversion
        private IProductRepository productRepository;

        //Dependency Injection (pattern)
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public int CreateProduct(Product product)
        {
            productRepository.Add(product);
            return product.Id;
        }

        public IList<Product> GetAllProducts()
        {

            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }

        public IList<Product> GetProductsByCategoryId(int categoryId)
        {
            return productRepository.GetProductsByCategoryId(categoryId);
        }

        public bool IsExists(int id)
        {
            return productRepository.IsExist(id);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.Update(product);

        }
    }
}
