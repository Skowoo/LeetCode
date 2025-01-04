namespace LeetCode.Easy
{
    internal static class DetectCapital
    {
        public static bool DetectCapitalUse(string word) // Fast
        {
            if (word.Length < 2)
                return true;

            bool firstCapital = char.IsUpper(word[0]);
            bool secondCapital = char.IsUpper(word[1]);

            if (!firstCapital && secondCapital)
                return false;

            for (int i = 2; i < word.Length; i++)
            {
                if (firstCapital && !secondCapital || !firstCapital)
                {
                    if (char.IsUpper(word[i]))
                        return false;
                }
                else
                {
                    if (char.IsLower(word[i]))
                        return false;
                }
            }

            return true;
        }
    }
}
