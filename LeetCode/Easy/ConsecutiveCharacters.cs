namespace LeetCode.Easy
{
    internal static class ConsecutiveCharacters
    {
        public static int MaxPower(string s)
        {
            int current = 0,
                max = 0;
            char prev = s[0];
            foreach (char c in s)
            {
                if (c == prev)
                    current++;
                else
                {
                    prev = c;
                    max = Math.Max(current, max);
                    current = 1;
                }
            }
            return Math.Max(current, max);
        }
    }
}
