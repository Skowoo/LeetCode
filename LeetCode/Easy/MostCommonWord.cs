using System.Text;

namespace LeetCode.Easy
{
    public static class MostCommonWord
    {
        public static string MostCommonWord_Func(string paragraph, string[] banned)
        {
            StringBuilder sb = new(paragraph);
            for (int i = 0; i < sb.Length; i++)
                if (!char.IsLetter(sb[i]))
                    sb[i] = ' ';

            var words = sb.ToString()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            Dictionary<string, int> keyValuePairs = [];

            foreach (var word in words)
            {
                if (banned.Contains(word))
                    continue;

                if (keyValuePairs.ContainsKey(word))
                    keyValuePairs[word]++;
                else
                    keyValuePairs[word] = 1;
            }

            return keyValuePairs.OrderByDescending(x => x.Value).First().Key;
        }
    }
}
