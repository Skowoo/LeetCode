namespace LeetCode.Easy
{
    internal static class AddDigits
    {
        public static int AddDigitsFunc(int num)
        {
            while (num > 9)
                num = num
                    .ToString()
                    .ToCharArray()
                    .Select(c => int.Parse(c.ToString()))
                    .Sum();

            return num;
        }
    }
}
