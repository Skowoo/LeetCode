namespace LeetCode.Medium
{
    internal class SumOfSquareNumbers
    {
        public static bool JudgeSquareSum(int c)
        {
            int a = 0;
            int b = (int)Math.Ceiling(Math.Sqrt(c));

            while (a <= b)
            {
                int candidate = a * a + b * b;
                if (candidate == c)
                    return true;
                else if (candidate < c && 0 <= candidate)
                    a++;
                else
                    b--;
            }

            return false;
        }
    }
}
