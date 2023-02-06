// See https://aka.ms/new-console-template for more information
using LINQ;

Console.WriteLine("Hello, World!");

Category phone = new() { Id = 1, Name = "Smart Phones" };
Category wearing = new() { Id = 2, Name = "Wear textile products" };
Category electronic = new() { Id = 3, Name = "Elektronik" };

List<Category> categories = new() { phone, wearing, electronic };

List<Product> products = new()
{
    new Product{ Id = 1, Name="Samsung A51", Description="Android Phone", IsStock=true, Price=5000, Rating=4.6, Category=phone },
    new Product{ Id = 2, Name="IPhone 14", Description="IOS Phone", IsStock=true, Price=10000, Rating=4.9, Category=phone },
    new Product{ Id = 3, Name="Xiaomi", Description="Android Phone", IsStock=false, Price=4000, Rating=4.2, Category=phone },
    new Product{ Id = 4, Name="Huawei", Description="Android Phone", IsStock=true, Price=4500, Rating=4.7, Category=phone },
    new Product{ Id = 5, Name="T-shirt", Description="Basic Shirt", IsStock=true, Price=300, Rating=4.6, Category=wearing },
    new Product{ Id = 6, Name="Pant", Description="Pant", IsStock=true, Price=400, Rating=4.6, Category=wearing },
    new Product{ Id = 7, Name="Dell XPS ", Description="Windows PC", IsStock=true, Price=12000, Rating=4.9, Category=electronic },
    new Product{ Id = 8, Name="Lenovo", Description="Windows PC", IsStock=true, Price=5000, Rating=4.6, Category=electronic },




};


var result = from product in products
             where product.Price > 4500
             select new { product.Name, product.Price };

//List<Product> resultList = new List<Product>();
//foreach (var item in products)
//{
//    if (item.Price>4500)
//    {
//        resultList.Add(item);
//    }
//}

Console.WriteLine("4500 TL'den pahalı ürünler:");
result.ToList().ForEach(p => Console.WriteLine($"{p.Name}: {p.Price}"));


//var anonym = new { Ad = "Türkay", Yas = 42 };
//anonym.
Console.WriteLine("4000 TL'den ucuz ürünler");
var cheapProducts = products.Where(p => p.Price < 4000)
                            .Select(p => new { Ad = p.Name, Fiyat = p.Price })
                            .ToList();


cheapProducts.ForEach(pr => Console.WriteLine($"{pr.Ad}: {pr.Fiyat}"));

Console.WriteLine("ID'si 5 olan ürünün detayları");

var tisort = products.FirstOrDefault(x => x.Id == 9);
//if (tisort != null)
//{
//    Console.WriteLine(tisort.Name);
//}
Console.WriteLine(tisort?.Name);
Console.WriteLine("AÇıklamasında 'Android' geçen ürünler");
Console.WriteLine("------------------------------------------");
var androids = products.Where(p => p.Description.Contains("Android"))
                       .ToList();

androids.ForEach(p => Console.WriteLine($"{p.Name}: {p.Description}"));

var orderedProducts = products.OrderBy(p => p.Name).ToList();
Console.WriteLine("Ürünlerin fiyata göre küçükten büyüğe sıralanması");
Console.WriteLine("-----------------------------------------------------");
orderedProducts.ForEach(p => Console.WriteLine($"{p.Name}: {p.Price}"));


Console.WriteLine("Rating'göre artandan -> azalana doğru");
Console.WriteLine("-----------------------------------------------------");
products.OrderByDescending(x => x.Rating).ToList().ForEach(p => Console.WriteLine($"{p.Name} {p.Rating}"));

Console.WriteLine("--------------- Aggregate Functions --------------------");
var totalPrice = products.Sum(x => x.Price);
var max = products.Max(x => x.Price);
var average = products.Where(p => p.Category?.Id == 1)
                      .Average(x => x.Rating);

var countInStock = products.Count(c => !c.IsStock);


/*
 *   Products
 *   Id         Name            CategoryId -----> FK
 *   -----------------------------------------
 *   1          XXX             1               
 *   2          AAA             1
 *   3          BBB             3
 * 
 *   
 *   Categories
 *   PK <----Id        Name
 *   ------------------------------------------
 *   1         Cat Name 1 
 *   2         Cat Name 2
 *   3.        Cat Name 3
 *   
 */
Console.WriteLine();
Console.WriteLine("------- JOIN ----------");
var joinQuery = categories.Join(products,
                                category => category,
                                product => product.Category,
                                (category, product) => new { KategoriAdi = category.Name, UrunAdi = product.Name }
                               ).ToList();

foreach (var item in joinQuery)
{
    Console.WriteLine($"{item.UrunAdi} {item.KategoriAdi}");
}


var joinAlternate = products.Select(p => new { UrunAdi = p.Name, KategoriAdi = p.Category?.Name });
foreach (var item in joinAlternate)
{
    Console.WriteLine($"{item.UrunAdi} {item.KategoriAdi}");
}

//Group by:

Console.WriteLine("Group by");

var group = products.GroupBy(
                        category => category.Category?.Name,
                        product => new { product.Name, product.Price },
                        (letter, products) => new
                        {
                            Key = letter,
                            Count = products.Count(),
                            Min = products.Min(x => x.Price),
                            Max = products.Max(x => x.Price)
                        }


                         );


foreach (var item in group)
{
    Console.WriteLine($"Kategori: {item.Key}");
    Console.WriteLine($"Toplam ürün sayısı: {item.Count}");
    Console.WriteLine($"En ucuz ürün fiyatı: {item.Min}");
    Console.WriteLine($"En pahalı ürün fiyatı:: {item.Max}");



}