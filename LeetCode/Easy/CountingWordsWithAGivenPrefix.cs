namespace LeetCode.Easy
{
    internal static class CountingWordsWithAGivenPrefix
    {
        public static int PrefixCount(string[] words, string pref)
        {
            return words.Count(x => x.StartsWith(pref));
        }
    }
}
