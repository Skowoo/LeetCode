using System.Text.RegularExpressions;

namespace LeetCode.Easy
{
    internal class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            Regex rgx = new("[^a-z]");
            s = rgx.Replace(s.ToLower(), "");

            Console.WriteLine(s);

            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[^(i + 1)])
                    return false;

            return true;
        }
    }
}
