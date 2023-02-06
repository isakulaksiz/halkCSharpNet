// See https://aka.ms/new-console-template for more information
using Polymorphism;

Console.WriteLine("Hello, World!");

TomatoSoup domatesCorbasi = new TomatoSoup();
ChickenWings kanat = new ChickenWings();

Cooker cooker = new Cooker();
cooker.Cook(domatesCorbasi);
cooker.Cook(kanat);

