using eshop.DataAccess.Data;
using eshop.Entities;

namespace eshop.DataAccess
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EshopDbContext eshopDbContext;

        public EFProductRepository(EshopDbContext eshopDbContext)
        {
            this.eshopDbContext = eshopDbContext;
        }

        public void Add(Product entity)
        {
            eshopDbContext.Products.Add(entity);
            eshopDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            return eshopDbContext.Products.Find(id);
        }

        public IList<Product> GetAll()
        {
            return eshopDbContext.Products.ToList();
        }

        public IList<Product> GetProductsByCategoryId(int categoryId)
        {
            return eshopDbContext.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public bool IsExist(int id)
        {
            return eshopDbContext.Products.Any(p => p.Id == id);
        }

        public IList<Product> SearchProductsByName(string productName)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            eshopDbContext.Products.Update(entity);
            //eshopDbContext.Entry<Product>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            eshopDbContext.SaveChanges();
        }
    }
}
