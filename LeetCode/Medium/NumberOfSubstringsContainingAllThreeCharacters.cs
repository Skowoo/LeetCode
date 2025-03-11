namespace LeetCode.Medium
{
    internal static class NumberOfSubstringsContainingAllThreeCharacters
    {
        public static int NumberOfSubstrings(string s)
        {
            int result = 0;
            int left = 0;
            Dictionary<char, int> dict = [];
            dict.Add('a', 0);
            dict.Add('b', 0);
            dict.Add('c', 0);

            for (int right = 0; right < s.Length; right++)
            {
                dict[s[right]]++;

                while (dict['a'] > 0 && dict['b'] > 0 && dict['c'] > 0)
                {
                    result += s.Length - right;
                    dict[s[left++]]--;
                }
            }

            return result;
        }
    }
}
