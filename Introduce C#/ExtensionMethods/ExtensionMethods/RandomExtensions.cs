namespace ExtensionMethods
{
    public static class RandomExtensions
    {
        public static char NextChar(this Random random)
        {
            return (char)random.Next(65, 90);
        }


        public static string NextString(this Random random, int length)
        {

            string result = string.Empty;

            for (int i = 0; i < length; i++)
            {
                result += random.NextChar();
            }
            return result;



        }
    }
}
