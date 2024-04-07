namespace LeetCode.Medium
{
    internal class ValidParenthesisString
    {
        public static bool CheckValidString(string s)
        {
            int minCounter = 0, maxCounter = 0;

            foreach (char c in s)
            {
                minCounter += c == '(' ? 1 : -1;
                maxCounter += c != ')' ? 1 : -1;

                if (maxCounter < 0)
                    break;
                minCounter = Math.Max(minCounter, 0);
            }

            return minCounter == 0;
        }
    }
}
