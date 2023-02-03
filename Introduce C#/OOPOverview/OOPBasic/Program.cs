// See https://aka.ms/new-console-template for more information

using OOPBasic;

Console.WriteLine("Hello, World!");

Person p1 = new Person
{
    //instance: örnek; turkay nesnesi, aynı zamanda Person class'ının bir örneğidir.
    Name = "Türkay"
};

Person p2 = p1;

p2.Name = "Elmas";

Console.WriteLine(p1.Name);



