namespace LeetCode.Easy
{
    internal static class CountTheDigitsThatDivideANumber
    {
        public static int CountDigits(int num)
        {
            string numberString = num.ToString();
            if (numberString.Length == 1)
                return 1;

            int result = 0;

            foreach (char c in numberString)
            {
                int currentDigit = int.Parse(c.ToString());

                if (num % currentDigit == 0)
                    result++;
            }

            return result;
        }
    }
}
