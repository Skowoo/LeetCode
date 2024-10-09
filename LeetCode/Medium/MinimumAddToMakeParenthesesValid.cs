namespace LeetCode.Medium
{
    internal class MinimumAddToMakeParenthesesValid
    {
        public static int MinAddToMakeValid(string s)
        {
            int left = 0,
                right = 0;

            foreach (char c in s)
            {
                if (c == '(')
                    left++;
                else if (left <= 0)
                    right++;
                else
                    left--;
            }

            return left + right;
        }
    }
}
