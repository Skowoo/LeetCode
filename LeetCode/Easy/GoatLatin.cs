using System.Text;

namespace LeetCode.Easy
{
    internal static class GoatLatin
    {
        public static string ToGoatLatin(string sentence)
        {
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            for (int i = 0; i < words.Length; i++)
            {
                StringBuilder sb = new(words[i]);
                if (vowels.Contains(words[i][0]))
                    sb.Append("ma");
                else
                {
                    sb.Append($"{words[i][0]}ma");
                    sb.Remove(0, 1);
                }

                for (int j = 0; j < i + 1; j++)
                    sb.Append('a');

                words[i] = sb.ToString();
            }

            return String.Join(" ", words);
        }
    }
}
