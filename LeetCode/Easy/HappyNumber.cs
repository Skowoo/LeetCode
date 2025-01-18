namespace LeetCode.Easy
{
    internal static class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            if (n < 10)
                return n == 1 || n == 7;

            int tempSum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                n /= 10;
                tempSum += digit * digit;
            }

            return IsHappy(tempSum);
        }
    }
}
