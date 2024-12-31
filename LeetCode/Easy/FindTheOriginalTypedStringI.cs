namespace LeetCode.Easy
{
    internal static class FindTheOriginalTypedStringI
    {
        public static int PossibleStringCount(string word)
        {
            int result = 1;

            for (int i = 1; i < word.Length; i++)
                if (word[i] == word[i - 1])
                    result++;

            return result;
        }
    }
}
