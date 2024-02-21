namespace LeetCode.Medium
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            List<char> chars = new();
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
                if (!chars.Contains(s[i]))
                    chars.Add(s[i]);
                else
                {
                    if (chars.Count > maxLength)
                        maxLength = chars.Count;

                    chars.RemoveRange(0, chars.IndexOf(s[i]) + 1);
                    chars.Add(s[i]);
                }

            return Math.Max(maxLength, chars.Count);
        }
    }
}

//Console.WriteLine(LengthOfLongestSubstring("aabaab!bb"));
//Console.WriteLine(LengthOfLongestSubstring("g43u6dc3f56ugvj5jucfgbibhr7gfj45fvch35  37yhv m737 h3 h37773 73 73y uch73hy37hy 3yh3h h7 y3hy7h ygj y3yhu375h  3 38 u83yh33h 3y rt hr hs thc rjt vrj dr jv dj5eryjlj4v4r  er jbtrjbve tu"));