namespace LeetCode.Easy
{
    internal class LengthOfLastWord
    {

        public static int LengthOfLastWordSlower(string s)
        {
            int counter = 0;
            bool initialized = false;
            for (int i = 1; i < s.Length + 1; i++)
                if (s[^i] != ' ' && initialized)
                    counter++;
                else if (initialized)
                    return counter;
                else if (s[^i] != ' ' && !initialized)
                {
                    initialized = true;
                    counter++;
                }

            return counter;
        }

        public static int LengthOfLastWordMedium(string s)
        {
            s = s.Trim();
            int counter = 0;
            for (int i = 1; i < s.Length + 1; i++)
                if (s[^i] != ' ')
                    counter++;
                else
                    return counter;
            return counter;
        }

        public static int LengthOfLastWordSlow(string s)
        {
            s = s.Trim();
            string[] strings = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return strings[^1].Length;
        }
    }
}
