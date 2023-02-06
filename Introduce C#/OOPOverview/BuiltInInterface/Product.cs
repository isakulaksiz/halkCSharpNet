using System.Collections;

namespace BuiltInInterface
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public double Price { get; set; }

        public int CompareTo(Product? other)
        {
            return Price > other.Price ? 1 : Price < other.Price ? -1 : 0;
        }
    }

    public class ShoppingCard : IEnumerable<Product>
    {
        private List<Product> _products = new List<Product>();
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> SortProducts()
        {
            _products.Sort();
            return _products;
        }

        //IEnumerable, Loosely Coupled (düşük bağlı) bir işlem amacıyla kullanıldı. Amaç sadece foreach ile dönmekse IEnumerable yeterlidir.
        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            foreach (var item in _products)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
