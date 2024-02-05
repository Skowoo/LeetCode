using System.Text;

namespace LeetCode.Medium
{
    internal class SortCharactersByFrequency
    {
        public static string FrequencySort(string s)
        {
            Dictionary<char, int> letters = new();

            foreach (char c in s)
                if (letters.ContainsKey(c))
                    letters[c]++;
                else
                    letters.Add(c, 1);

            StringBuilder sb = new();

            foreach (var l in letters.OrderByDescending(x => x.Value))
                for (int i = 0; i < l.Value; i++)
                    sb.Append(l.Key);

            return sb.ToString();
        }
    }
}
