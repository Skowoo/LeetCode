namespace LeetCode.Medium
{
    internal class ReplaceWords
    {
        // Uneffective solution
        public static string ReplaceWords_Uneffective(IList<string> dictionary, string sentence)
        {
            IList<string> words = sentence.Split(' ');
            for (int i = 0; i < words.Count; i++)
            {
                var candidate = dictionary
                    .Where(x => words[i]
                    .StartsWith(x))
                    .OrderBy(x => x.Length)
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(candidate))
                    words[i] = candidate;
            }
            return string.Join(" ", words);
        }
    }
}
