namespace LeetCode.Medium
{
    internal static class ConstructKPalindromeStrings
    {
        public static bool CanConstruct(string s, int k)
        {
            if (s.Length < k)
                return false;

            int[] chars = new int[26];
            foreach (char c in s)
                chars[c - 97]++;

            int oddCounter = 0;
            foreach (int c in chars)
                if (c % 2 == 1)
                    oddCounter++;

            return oddCounter < k;
        }
    }
}
