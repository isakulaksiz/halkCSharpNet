// See https://aka.ms/new-console-template for more information
using GenericTypes;

Console.WriteLine("Hello, World!");
GeneralPoint generalPoint = new GeneralPoint
{
    X = 15
};
generalPoint.SetPosition("dkd", false);
//int value = (int)generalPoint.X;

GenericPoint<decimal> point = new GenericPoint<decimal>
{
    X = 1.0M,
    Y = 0.8M
};
point.Reset();

GenericPoint<double> genericPoint = new GenericPoint<Double>();

if (isEqual(15.0, 15.0))
{
    Console.WriteLine("eşittir");
}
else
{
    Console.WriteLine("eşit değildir");
}

bool isEqual<T, W>(T value1, W value2) where T : struct, IComparable
                                       where W : struct, IComparable
{
    return value1.CompareTo(value2) == 0;
}