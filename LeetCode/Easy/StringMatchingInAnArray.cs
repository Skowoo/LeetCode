namespace LeetCode.Easy
{
    internal static class StringMatchingInAnArray
    {
        public static IList<string> StringMatching(string[] words)
        {
            List<string> result = [];

            for (int i = 0; i < words.Length; i++)
                for (int j = 0; j < words.Length; j++)
                    if (i != j && words[j].Contains(words[i]))
                    {
                        result.Add(words[i]);
                        break;
                    }

            return result;
        }
    }
}
