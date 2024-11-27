namespace LeetCode.Easy
{
    internal static class ValidPerfectSquare
    {
        public static bool IsPerfectSquare(int num)
        {
            long left = 0,
                right = num;

            if (num == 1)
                return true;

            while (right - left > 1)
            {
                long mid = (left + right) / 2;

                if (mid * mid > num)
                    right = mid;
                else if (mid * mid < num)
                    left = mid;
                else
                    return true;
            }

            return false;
        }
    }
}
