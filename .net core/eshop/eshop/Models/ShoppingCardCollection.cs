using eshop.Entities;

namespace eshop.Models
{

    public class ProductInCard
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class ShoppingCardCollection
    {
        public List<ProductInCard> Products { get; set; } = new List<ProductInCard>();

        public void AddToCard(Product product, int quantity)
        {

            var existingProduct = Products.FirstOrDefault(p => p.Product.Id == product.Id);
            if (existingProduct == null)
            {
                Products.Add(new ProductInCard { Product = product, Quantity = quantity });

            }
            else
            {
                existingProduct.Quantity += quantity;
            }

        }

        public void Clear() => Products.Clear();
        public double GetTotalPrice() => Products.Sum(p => p.Product.Price * p.Quantity);
        public void RemoveProductInCard(int id) => Products.RemoveAll(p => p.Product.Id == id);
    }
}
