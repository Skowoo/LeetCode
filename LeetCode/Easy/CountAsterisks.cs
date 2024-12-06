namespace LeetCode.Easy
{
    internal static class CountAsterisks
    {
        public static int CountAsterisksFunc(string s)
        {
            var words = s.Split('|');
            List<string> validWords = [];
            bool sw = true;
            foreach (var word in words)
            {
                if (sw)
                    validWords.Add(word);
                sw = !sw;
            }
            var validChars = String.Join("", validWords).ToCharArray();
            return validChars.Count(x => x == '*');
        }
    }
}
