namespace LeetCode.Easy
{
    internal static class CapitalizeTheTitle
    {
        public static string CapitalizeTitle(string title)
        {
            string[] words = title.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > 2)
                    words[i] = words[i][..1].ToUpper() + words[i][1..].ToLower();
                else
                    words[i] = words[i].ToLower();

            return string.Join(" ", words);
        }
    }
}
