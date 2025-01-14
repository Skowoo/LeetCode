namespace LeetCode.Easy
{
    internal static class WordPattern
    {
        public static bool WordPattern_Func(string pattern, string s)
        {
            Dictionary<char, string> charStringPairs = [];
            Dictionary<string, char> stringCharPairs = [];
            var words = s.Split(' ');

            if (pattern.Length != words.Length)
                return false;

            for (int i = 0; i < words.Length; i++)
            {
                charStringPairs.TryAdd(pattern[i], words[i]);
                stringCharPairs.TryAdd(words[i], pattern[i]);

                if (charStringPairs[pattern[i]] != words[i])
                    return false;
                if (stringCharPairs[words[i]] != pattern[i])
                    return false;
            }

            return true;
        }
    }
}
