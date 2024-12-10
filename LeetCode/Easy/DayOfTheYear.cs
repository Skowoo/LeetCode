namespace LeetCode.Easy
{
    internal static class DayOfTheYear
    {
        public static int DayOfYear(string date)
        {
            var firstDay = new DateTime(int.Parse(date.Split('-')[0]), 01, 01);
            var currentDay = DateTime.Parse(date);
            return (currentDay - firstDay).Days + 1;
        }
    }
}
