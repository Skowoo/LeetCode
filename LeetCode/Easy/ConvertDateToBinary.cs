namespace LeetCode.Easy
{
    internal static class ConvertDateToBinary
    {
        public static string ConvertDateToBinary_Func(string date)
        {
            var parts = date.Split('-');
            List<string> result = [];
            foreach (var part in parts)
                result.Add(Convert.ToString(int.Parse(part), 2));

            return String.Join('-', result);
        }
    }
}
