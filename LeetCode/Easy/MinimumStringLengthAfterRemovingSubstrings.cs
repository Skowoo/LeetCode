using System.Text;

namespace LeetCode.Easy
{
    internal class MinimumStringLengthAfterRemovingSubstrings
    {
        public static int MinLength(string s)
        {
            StringBuilder sb;
            while (s.Contains("AB") || s.Contains("CD"))
            {
                sb = new(s);
                sb.Replace("AB", null);
                sb.Replace("CD", null);
                s = sb.ToString();
            }
            return s.Length;
        }
    }
}
