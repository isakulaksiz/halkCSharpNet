// See https://aka.ms/new-console-template for more information
using Delegates;

Console.WriteLine("Hello, World!");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//.net 1.0
var evenNumbers = FilterHelper.Filter(numbers, isEven);
//.net 2.0
var oddNumbers = FilterHelper.Filter(numbers, delegate (int x) { return x % 2 == 1; });
//.net 3.5
var biggerThenFive = FilterHelper.Filter(numbers, n => n > 5);

Console.WriteLine("Çift sayılar");
showItems(evenNumbers);
Console.WriteLine("Tek sayılar");
showItems(oddNumbers);
Console.WriteLine("5'den büyük...");
showItemsAlternative(biggerThenFive);





bool isEven(int number)
{
    return number % 2 == 0;
}

void showItems(int[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}

void showItemsAlternative(int[] array)
{
    array.ToList().ForEach(x => Console.WriteLine(x));
}

