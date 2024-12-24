namespace LeetCode.Easy
{
    internal static class KeyboardRow
    {
        public static string[] FindWords(string[] words)
        {
            string[] rows = ["qwertyuiop", "asdfghjkl", "zxcvbnm"];
            List<string> result = [];
            foreach (string word in words)
            {
                int rowNumber = 0;
                for (int i = 0; i < rows.Length; i++)
                    if (rows[i].Contains(word.ToLower()[0]))
                        rowNumber = i;

                bool isAccepted = true;
                foreach (char ch in word.ToLower())
                    if (!rows[rowNumber].Contains(ch))
                    {
                        isAccepted = false;
                        break;
                    }

                if (isAccepted)
                    result.Add(word);
            }

            return [.. result];
        }
    }
}
