namespace LeetCode.Easy
{
    internal class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 2)
                return 2;

            int[] steps = new int[n + 1];
            steps[0] = 1;
            steps[1] = 2;

            for (int i = 2; i <= n; i++)
                steps[i] = steps[i - 2] + steps[i - 1];

            return steps[n - 1];
        }
    }
}
