namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static string RemoveMiddleEmpty(this string value)
        {
            return value.Replace(" ", "");
        }
    }
}
