namespace LeetCode.Easy
{
    internal static class CountPrefixAndSuffixPairsI
    {
        public static int CountPrefixSuffixPairs(string[] words)
        {
            HashSet<string> fixes = [];
            int result = 0;

            foreach (var word in words)
                for (int len = 1; len <= word.Length; len++)
                {
                    fixes.Add(word[..len]);
                    fixes.Add(word[^len..]);
                }

            for (int i = 0; i < words.Length; i++)
                for (int j = i + 1; j < words.Length; j++)
                    if (fixes.Contains(words[j]) && words[j].StartsWith(words[i]) && words[j].EndsWith(words[i]))
                        result++;

            return result;
        }
    }
}
