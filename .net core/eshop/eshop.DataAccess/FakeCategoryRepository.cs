using eshop.Entities;

namespace eshop.DataAccess
{
    public class FakeCategoryRepository : ICategoryRepository
    {
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
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            return new List<Category>()
            {
                new() { Id =1, Name="Elektronik"},
                new() { Id =2, Name="Kozmetik"},
                new() { Id =3, Name="Giyim"},
            };
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
