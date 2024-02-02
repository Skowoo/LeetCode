namespace LeetCode.Medium
{
    internal class SequentialDigitsCls
    {
        public static IList<int> SequentialDigits(int low, int high)
        {
            List<int> results = new();
            string digits = "123456789";
            string lowString = low.ToString();
            int startingIndex = lowString[0] - 49;

            while (true)
            {
                lowString = low.ToString();
                if (startingIndex + lowString.Length > digits.Length)
                {
                    low = (int)Math.Pow(10, lowString.Length);

                    if (low > 123456789)
                        break;

                    startingIndex = 0;
                    continue;
                }
                string result = digits.Substring(startingIndex, lowString.Length);
                int parsedResult = int.Parse(result);

                if (parsedResult < low)
                {
                    startingIndex++;
                    continue;
                }

                low = parsedResult;

                if (low > high)
                    break;

                results.Add(low);
                startingIndex++;
            }

            return results.ToArray();
        }
    }
}
