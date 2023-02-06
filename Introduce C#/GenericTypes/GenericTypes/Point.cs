namespace GenericTypes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void SetPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }




    }

    public class DoublePoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void SetPosition(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Reset()
        {
            X = 0.0;
            Y = 0.0;
        }
    }

    public class GeneralPoint
    {
        public object X { get; set; }
        public object Y { get; set; }

        public void SetPosition(object x, object y)
        {
            X = x;
            Y = y;
        }



        public void Reset()
        {
            X = 0.0;
            Y = 0.0;
        }
    }

    public class GenericPoint<T> where T : struct, IComparable
    {
        public T X { get; set; }
        public T Y { get; set; }

        public void SetPosition(T x, T y)
        {
            X = x;
            Y = y;
        }



        public void Reset()
        {
            X = default!;
            Y = default(T);
        }

        public bool isEqual()
        {
            return X.CompareTo(Y) == 0;
        }

        //public Random MyProperty { get; set; } = default!;

    }





}
