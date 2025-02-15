using System.Text;

namespace LeetCode.Easy
{
    internal static class ReplaceAllDigitsWithCharacters
    {
        public static string ReplaceDigits(string s)
        {
            StringBuilder sb = new(s);

            for (int i = 1; i < s.Length; i += 2)
                sb[i] = (char)(s[i - 1] + (s[i] - 48));

            return sb.ToString();
        }
    }
}
