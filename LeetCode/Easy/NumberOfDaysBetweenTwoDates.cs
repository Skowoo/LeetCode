namespace LeetCode.Easy
{
    internal class NumberOfDaysBetweenTwoDates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S6562", Justification = "Simple solution")]
        public static int DaysBetweenDates(string date1, string date2)
        {
            var firstDateComponents = date1.Split('-');
            var secondDateComponents = date2.Split('-');
            var firstDate = new DateTime(int.Parse(firstDateComponents[0]), int.Parse(firstDateComponents[1]), int.Parse(firstDateComponents[2]));
            var secondDate = new DateTime(int.Parse(secondDateComponents[0]), int.Parse(secondDateComponents[1]), int.Parse(secondDateComponents[2]));
            var timespan = secondDate - firstDate;
            return Math.Abs(timespan.Days);
        }
    }
}
