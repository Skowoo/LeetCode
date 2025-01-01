namespace LeetCode.Easy
{
    internal static class MaximumScoreAfterSplittingAString
    {
        public static int MaxScore(string s)
        {
            int allZero = 0,
                currZero = 0,
                result = -1;

            foreach (var c in s)
                if (c == '0') allZero++;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == '0')
                {
                    currZero++;
                    allZero--;
                }
                result = Math.Max(result, currZero + (s.Length - allZero - i));
            }

            return result;
        }
    }
}
