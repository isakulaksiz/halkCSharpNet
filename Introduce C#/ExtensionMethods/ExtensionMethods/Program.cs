// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");

string companyName = "Halk bank";
companyName.RemoveMiddleEmpty();

int x = 8;
Console.WriteLine(x.GetPower(3));
Console.WriteLine(x.GetSquare());

Console.WriteLine(DateTime.Now.GetTotalWorkDays(null));
for (int i = 0; i < 100; i++)
{
    Console.Write(new Random().NextString(6) + " ");

}
