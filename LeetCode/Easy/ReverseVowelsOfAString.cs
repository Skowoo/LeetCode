using System.Text;

namespace LeetCode.Easy
{
    internal class ReverseVowelsOfAString
    {

        public static string ReverseVowels(string s)
        {
            char[] vowels = ("aeiouAEIOU").ToCharArray();
            List<char> chars = [];
            List<int> indexes = [];

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    chars.Add(s[i]);
                    indexes.Add(i);
                }
            }

            chars.Reverse();
            StringBuilder result = new StringBuilder(s);

            foreach (int i in indexes)
            {
                result[i] = chars[0];
                chars.RemoveAt(0);
            }

            return result.ToString();
        }
    }
}
