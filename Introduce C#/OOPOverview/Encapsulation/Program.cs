// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");
Product phone = new Product
{
    //phone.SetPrice(-15);
    Name = "Samsung"
};

Product keyboard = new Product
{
    Name = "Logitech"
};
keyboard.SetPrice(1000);

if (!keyboard.Rating.HasValue)
{
    Console.WriteLine("Ürün puanı belirtilmemiş");
}

double? bilmemNe = null;
Nullable<double> bilmemne2 = null;


Product mouse = new Product { Name = "Logitech", Rating = null, Description = "Bluetooth" };
mouse.Rating = 4.8;
