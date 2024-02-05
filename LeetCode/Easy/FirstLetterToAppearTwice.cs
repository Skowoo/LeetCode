namespace LeetCode.Easy
{
    internal class FirstLetterToAppearTwice
    {
        public static char RepeatedCharacter(string s)
        {
            List<char> chars = new();
            foreach (char c in s)
                if (!chars.Contains(c))
                    chars.Add(c);
                else return c;

            return '?';
        }
    }
}
