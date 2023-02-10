using eshop.DataAccess.Data;
using eshop.Entities;

namespace eshop.DataAccess
{
    public class EFCategoryRepository : ICategoryRepository
    {

        private EshopDbContext dbContext;

        public EFCategoryRepository(EshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            return dbContext.Categories.Find(id);
        }

        public IList<Category> GetAll()
        {
            return dbContext.Categories.ToList();
        }

        public bool IsExist(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
