using System.Text;

namespace LeetCode.Medium
{
    internal class StringCompressionIII
    {
        public static string CompressedString(string word)
        {
            StringBuilder sb = new();
            int count = 0;
            char prev = word[0];

            if (word.Length == 1)
                return $"1{word}";

            for (int i = 1; i < word.Length; i++)
            {
                count++;
                if (count == 9 || word[i] != prev)
                {
                    sb.Append($"{count}{prev}");
                    prev = word[i];
                    count = 0;
                }

                if (i == word.Length - 1)
                {
                    if (word[i] == prev)
                        sb.Append($"{++count}{prev}");
                    else
                        sb.Append($"1{word[i]}");
                }
            }

            return sb.ToString();
        }
    }
}
