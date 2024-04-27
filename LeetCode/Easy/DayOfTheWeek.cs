namespace LeetCode.Easy
{
    internal class DayOfTheWeek
    {
        public static string DayOfTheWeek_Func(int day, int month, int year) => new DateTime(year, month, day).DayOfWeek.ToString();
    }
}
