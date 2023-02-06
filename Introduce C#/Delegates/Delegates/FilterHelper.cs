namespace Delegates
{
    public static class FilterHelper
    {

        //public delegate bool criteria(int value);

        public static int[] Filter(int[] numbers, Func<int, bool> filteringCriteria)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (var item in numbers)
            {
                if (filteringCriteria(item))
                {
                    filteredNumbers.Add(item);
                }
            }

            return filteredNumbers.ToArray();

        }
    }
}
