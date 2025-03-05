namespace LeetCode.Medium
{
    internal static class CountTotalNumberOfColoredCells
    {
        public static long ColoredCells(int n)
        {
            return 2 * (long)Math.Pow(n, 2) - 2 * n + 1;
        }
    }
}
