namespace ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static int GetTotalWorkDays(this DateTime dateTime, List<DateTime> nationalHolidays)
        {
            var firstDate = new DateTime(dateTime.Year, 1, 1);
            var lastDate = new DateTime(dateTime.Year, 12, 31);

            int totalWorkDays = 0;

            for (DateTime day = firstDate; day <= lastDate; day = day.AddDays(1))
            {
                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                {
                    totalWorkDays++;
                }
            }

            return totalWorkDays;
        }
    }
}
