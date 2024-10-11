namespace LeetCode.Medium
{
    internal class SellDiminishingValuedColoredBalls
    {
        public static int MaxProfit(int[] inventory, int orders)
        {
            var (result, min, max) = (0L, 1L, (long)inventory.Max());
            while (min <= max)
            {
                long middle = min + (max - min) / 2;
                var (sum, ballsToSell) = (0L, 0L);
                foreach (var n in inventory)
                {
                    if (n < middle)
                        continue;

                    long balls = n - middle + 1;
                    ballsToSell += balls;
                    sum += balls * (2 * middle + (balls - 1) * 1) / 2;
                }

                if (ballsToSell < orders)
                {
                    max = middle - 1;
                    continue;
                }

                (result, min) = (sum, middle + 1);
                result -= (ballsToSell - orders) * middle;
            }
            result %= 1_000_000_007;
            return (int)result;
        }
    }
}
