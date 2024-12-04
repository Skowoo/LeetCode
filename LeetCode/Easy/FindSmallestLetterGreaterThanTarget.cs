namespace LeetCode.Easy
{
    internal static class FindSmallestLetterGreaterThanTarget
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            if (letters[letters.Length - 1] < target)
                return letters[0];

            for (int i = 0; i < letters.Length; i++)
                if (target < letters[i])
                    return letters[i];

            return letters[0];
        }
    }
}
