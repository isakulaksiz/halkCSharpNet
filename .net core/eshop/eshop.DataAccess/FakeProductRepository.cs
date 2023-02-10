using eshop.Entities;

namespace eshop.DataAccess
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> products;
        public FakeProductRepository()
        {
            products = new()
            {
                new() { Id=1, Description="Test Açıklama", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name", Price=1, CategoryId=1},
                new() { Id=2, Description="Test Açıklama 2", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 2", Price=1, CategoryId =2},
                new() { Id=3, Description="Test Açıklama 3", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 3", Price=1, CategoryId =1},
                new() { Id=4, Description="Test Açıklama 4", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1, CategoryId=3},
                    new() { Id=5, Description="Test Açıklama 5", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name", Price=1, CategoryId=1},
                new() { Id=6, Description="Test Açıklama 6", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 2", Price=1, CategoryId =2},
                new() { Id=7, Description="Test Açıklama 7", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 3", Price=1, CategoryId =1},
                new() { Id=8, Description="Test Açıklama 8", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1, CategoryId=3},
                    new() { Id=9, Description="Test Açıklama 9", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name", Price=1, CategoryId=1},
                new() { Id=10, Description="Test Açıklama 12", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 2", Price=1, CategoryId =2},
                new() { Id=11, Description="Test Açıklama 13", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 3", Price=1, CategoryId =1},
                new() { Id=14, Description="Test Açıklama 14", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1, CategoryId=3},
                    new() { Id=21, Description="Test Açıklama 15", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name", Price=1, CategoryId=1},
                new() { Id=12, Description="Test Açıklama 20", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 2", Price=1, CategoryId =2},
                new() { Id=13, Description="Test Açıklama 23", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 3", Price=1, CategoryId =1},
                new() { Id=24, Description="Test Açıklama 24", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1, CategoryId=3},
                  new() { Id=24, Description="Test Açıklama 24", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1, CategoryId=3},
                  new() { Id=24, Description="Test Açıklama 24", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1, CategoryId=3},  new() { Id=24, Description="Test Açıklama 24", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1, CategoryId=3},  new() { Id=24, Description="Test Açıklama 24", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1, CategoryId=3},

            };
        }
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public IList<Product> GetAll()
        {
            return products;
        }

        public IList<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public bool IsExist(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchProductsByName(string productName)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
