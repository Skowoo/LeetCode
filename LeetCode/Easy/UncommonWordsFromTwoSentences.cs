namespace LeetCode.Easy
{
    internal class UncommonWordsFromTwoSentences
    {
        public static string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> wordsCount = [];
            foreach (string s in s1.Split(' '))
                if (wordsCount.TryGetValue(s, out int value))
                    wordsCount[s] = ++value;
                else
                    wordsCount.Add(s, 1);

            foreach (string s in s2.Split(' '))
                if (wordsCount.TryGetValue(s, out int value))
                    wordsCount[s] = ++value;
                else
                    wordsCount.Add(s, 1);

            return wordsCount.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
        }
    }
}
