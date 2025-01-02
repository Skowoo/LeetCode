namespace LeetCode.Medium
{
    internal static class CountVowelStringsInRanges
    {
        public static int[] VowelStrings(string[] words, int[][] queries)
        {
            int[] countedArr = new int[words.Length];
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
                if (GoodWord(words[i]))
                    countedArr[i] = ++counter;
                else
                    countedArr[i] = counter;

            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                if (queries[i][0] == 0)
                    result[i] = countedArr[queries[i][1]];
                else
                    result[i] = countedArr[queries[i][1]] - countedArr[queries[i][0] - 1];
            }


            return result;

            static bool GoodWord(string word)
            {
                char[] vowels = ['a', 'e', 'i', 'o', 'u'];
                bool start = false;
                bool end = false;

                foreach (char vowel in vowels)
                {
                    if (word[0] == vowel)
                        start = true;

                    if (word[^1] == vowel)
                        end = true;
                }

                return start && end;
            }
        }
    }
}
