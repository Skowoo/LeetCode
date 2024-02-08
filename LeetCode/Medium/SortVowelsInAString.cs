using System.Text;

namespace LeetCode.Medium
{
    internal class SortVowelsInAString
    {
        public static string SortVowels(string s)
        {
            char[] vowelsArray = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<int> vowelsIndexes = new();
            List<char> vowels = new();

            for (int i = 0; i < s.Length; i++)
                if (vowelsArray.Contains(s[i]))
                {
                    vowelsIndexes.Add(i);
                    vowels.Add(s[i]);
                }

            vowels = vowels.OrderBy(x => (byte)x).ToList();

            StringBuilder sb = new(s);

            int vowelIndexesListIndexer = 0;

            foreach (int i in vowelsIndexes)
                sb[i] = vowels[vowelIndexesListIndexer++];

            return sb.ToString();
        }
    }
}
