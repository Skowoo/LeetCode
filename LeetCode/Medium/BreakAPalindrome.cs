using System.Text;

namespace LeetCode.Medium
{
    internal class BreakAPalindrome
    {
        public static string BreakPalindrome(string palindrome)
        {
            if (palindrome.Length == 1)
                return string.Empty;

            StringBuilder sb = new StringBuilder(palindrome);

            for (int i = 0; i < palindrome.Length / 2; i++)
            {
                if (palindrome[i] != 'a')
                {
                    sb[i] = 'a';
                    return sb.ToString();
                }
            }

            sb[sb.Length - 1] = 'b';

            return sb.ToString();
        }
    }
}

// Console.WriteLine(BreakPalindrome("a"));