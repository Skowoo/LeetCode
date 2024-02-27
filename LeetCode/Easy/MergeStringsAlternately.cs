namespace LeetCode.Easy
{
    internal class MergeStringsAlternately
    {

        public static string MergeAlternately(string word1, string word2)
        {
            string result = string.Empty;

            int wordsIndexer = 0;

            while (true)
            {
                if (word1.Length > wordsIndexer)
                    result += word1[wordsIndexer];

                if (word2.Length > wordsIndexer)
                    result += word2[wordsIndexer];

                wordsIndexer++;

                if (wordsIndexer >= Math.Max(word1.Length, word2.Length))
                    break;
            }

            return result;
        }
    }
}

// Console.WriteLine(MergeAlternately("abcde","123456789"));