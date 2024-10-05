using System.Text;

namespace LeetCode.Easy
{
    internal class FindTheEncryptedString
    {
        public static string GetEncryptedString(string s, int k)
        {
            StringBuilder sb = new(s);
            for (int i = 0; i < s.Length; i++)
                sb[i] = (char)s[(i + k) % s.Length];

            return sb.ToString();
        }
    }
}
