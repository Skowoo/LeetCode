namespace LeetCode.Easy
{
    internal class Largest3SameDigitNumberInString
    {
        public static string LargestGoodInteger(string num)
        {
            char previousDigit = 'x';
            string result = string.Empty;
            List<string> candidates = new();

            foreach (char c in num)
            {
                if (c == previousDigit)
                {
                    result += c;
                }
                else
                {
                    result = string.Empty + c;
                    previousDigit = c;
                }

                if (result.Length == 3)
                    candidates.Add(result);
            }

            if (candidates.Any())
                return candidates.OrderByDescending(x => x).First();
            else
                return string.Empty;
        }
    }
}
