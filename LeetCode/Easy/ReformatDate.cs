namespace LeetCode.Easy
{
    internal static class ReformatDate
    {
        public static string ReformatDate_Func(string date)
        {
            var parts = date.Split(' ');
            string[] months = ["Zero", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
            return $"{parts[2]}-{Array.IndexOf(months, parts[1]):D2}-{int.Parse(parts[0][..^2]):D2}";
        }
    }
}
