using System.Text;

namespace LeetCode.Medium
{
    internal class RemoveKDigits
    {
        public static string RemoveKdigits(string num, int k)
        {
            if (num.Length == k)
                return "0";

            StringBuilder result = new();

            foreach (char c in num)
            {
                while (k > 0 && result.Length > 0 && result[^1] > c)
                {
                    result.Remove(result.Length - 1, 1);
                    k--;
                }
                result.Append(c);
            }

            while (k > 0)
            {
                result.Remove(result.Length - 1, 1);
                k--;
            }

            while (result.Length > 1 && result[0] == '0')
                result.Remove(0, 1);

            return result.ToString();
        }
    }
}
