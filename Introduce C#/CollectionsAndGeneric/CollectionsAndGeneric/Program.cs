using System.Collections;

List<string> words = new List<string>();

//boxing:
object value = "Deneme";
//unboxing:
//string strValue = (string)value;
//int error = (int)value;


//Generic olmasaydı:
ArrayList arrayList = new ArrayList
{
    15
};
int firstNumber = (int)arrayList[0];

//Generic iyi ki var :)
List<int> numberList = new List<int>
{
    23,
    -12,
    9,
    542,
    98,
    25,
    15
};
int firstNumberOfList = numberList[0];

if (numberList.Contains(15))
{
    Console.WriteLine("15 koleksiyonda var");
}

numberList.Sort();
Console.WriteLine("Sıralanmış liste:");
foreach (var item in numberList)
{
    Console.WriteLine(item);
}




