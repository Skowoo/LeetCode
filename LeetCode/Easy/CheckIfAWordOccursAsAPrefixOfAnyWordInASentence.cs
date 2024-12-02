namespace LeetCode.Easy
{
    internal static class CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
    {
        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            int result = -1;
            var words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
                for (int j = 0; j <= words[i].Length; j++)
                {
                    if (j == searchWord.Length)
                        return i + 1;

                    if (j == words[i].Length)
                        break;

                    if (searchWord[j] != words[i][j])
                        break;
                }

            return result;
        }
    }
}
