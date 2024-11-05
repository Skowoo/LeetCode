namespace LeetCode.Medium
{
    internal class MinimumNumberOfChangesToMakeBinaryStringBeautiful
    {
        public static int MinChanges(string s)
        {
            int result = 0;

            for (int i = 1; i < s.Length; i += 2)
                if (s[i] != s[i - 1])
                    result++;

            return result;
        }
    }
}
