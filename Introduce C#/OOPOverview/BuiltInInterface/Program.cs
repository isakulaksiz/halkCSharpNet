// See https://aka.ms/new-console-template for more information
using BuiltInInterface;

Console.WriteLine("Hello, World!");

Product product1 = new Product() { Id = 1, Name = "X", CreatedDate = DateTime.Now.AddDays(-20), Price = 520 };
Product product2 = new Product() { Id = 2, Name = "Y", CreatedDate = DateTime.Now.AddDays(-250), Price = 120 };
Product product3 = new Product() { Id = 3, Name = "A", CreatedDate = DateTime.Now.AddDays(-250), Price = 350 };
Product product4 = new Product() { Id = 3, Name = "B", CreatedDate = DateTime.Now.AddDays(-250), Price = 1000 };
Product product5 = new Product() { Id = 3, Name = "C", CreatedDate = DateTime.Now.AddDays(-250), Price = 752 };
Product product6 = new Product() { Id = 3, Name = "D", CreatedDate = DateTime.Now.AddDays(-250), Price = 520 };


ShoppingCard shoppingCard = new ShoppingCard();
shoppingCard.AddProduct(product1);
shoppingCard.AddProduct(product2);
shoppingCard.AddProduct(product3);
shoppingCard.AddProduct(product4);
shoppingCard.AddProduct(product5);
shoppingCard.AddProduct(product6);


//shoppingCard.GetProducts();
//foreach (var product in shoppingCard.GetProducts())
//{
//    Console.WriteLine(product.Name);
//}

//Dikkat: IEnumerable sayesinde kendi nesnemiz içinde foreach ile döndük
foreach (var product in shoppingCard)
{
    Console.WriteLine($"{product.Name} {product.Price} {product.CreatedDate.ToLongDateString()}");
}


Console.WriteLine("Fiyata göre sıralı..........");


var sorted = shoppingCard.SortProducts();
foreach (var item in sorted)
{
    Console.WriteLine($"{item.Name}: {item.Price} - {item.CreatedDate}");
}


sorted.Add(new Product { Name = "test" });


