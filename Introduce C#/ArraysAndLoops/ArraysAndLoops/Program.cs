int[] numbers = { 55, 23, -4, 19, 26, 123, 0 };
int minimum = numbers[0];
for (int index = 1; index < numbers.Length; index++)
{
	if (minimum > numbers[index])
	{
		minimum = numbers[index];
	}
}

Console.WriteLine(minimum);
//Console.WriteLine(numbers.ToList().Min());
//Console.WriteLine(numbers.ToList().Max());

string[] cities = { "Istanbul", "Cankırı", "Van", "Yozgat", "Bitlis" };
Console.WriteLine("Aradığınız il:");
string searchingValue = Console.ReadLine();
bool isCityFinded = false;
for (int i = 0; i < cities.Length; i++)
{
	if (searchingValue == cities[i])
	{
		isCityFinded = true;
		break;
	}
}

foreach (var city in cities)
{
	if (searchingValue == city)
	{
		isCityFinded = true;
		break;
	}
}

foreach (var city in cities)
{
	if (city.Length < 5)
	{
		continue;
	}
	Console.WriteLine(city);
}

if (!isCityFinded)
{
	Console.WriteLine($"{searchingValue} şehirlerde yok!");
}
else
{
	Console.WriteLine($"{searchingValue} şehirlerde var");
}

//1. Yeni bir array oluştur, bir önceki array'in eleman sayısından bir fazla olsun.
//2. Eski array'in tüm elemanlarını yeni array'a taşı (kopyala)
//3. Yeni ili (örnek:Bilecik) yeni array'in son elemanına ekle
