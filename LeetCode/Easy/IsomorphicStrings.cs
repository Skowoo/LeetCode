namespace LeetCode.Easy
{
    internal class IsomorphicStrings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> letterPairs = new();
            for (int i = 0; i < s.Length; i++)
                if (letterPairs.ContainsKey(s[i]))
                {
                    if (letterPairs[s[i]] != t[i])
                        return false;
                }
                else
                    letterPairs.Add(s[i], t[i]);

            letterPairs.Clear();
            for (int i = 0; i < s.Length; i++)
                if (letterPairs.ContainsKey(t[i]))
                {
                    if (letterPairs[t[i]] != s[i])
                        return false;
                }
                else
                    letterPairs.Add(t[i], s[i]);

            return true;
        }
    }
}
