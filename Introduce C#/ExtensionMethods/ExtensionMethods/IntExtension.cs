namespace ExtensionMethods
{
    public static class IntExtension
    {
        public static int GetSquare(this int value) => (int)Math.Pow(value, 2);
        public static int GetPower(this int value, int power) => (int)Math.Pow(value, power);


    }
}
