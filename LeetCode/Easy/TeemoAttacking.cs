namespace LeetCode.Easy
{
    internal static class TeemoAttacking
    {
        public static int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int result = 0;

            for (int i = 1; i < timeSeries.Length; i++)
            {
                int maxPossibleTime = timeSeries[i] - timeSeries[i - 1];

                if (maxPossibleTime > duration)
                    result += duration;
                else
                    result += maxPossibleTime;
            }

            result += duration;

            return result;
        }
    }
}
