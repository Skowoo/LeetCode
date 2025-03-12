namespace LeetCode.Easy
{
    internal static class MaximumCountOfPositiveIntegerAndNegativeInteger
    {
        public static int MaximumCount(int[] nums)
        {
            int positiveCount = 0,
                negativeCount = 0;

            foreach (var num in nums)
                if (num > 0)
                    positiveCount++;
                else if (num < 0)
                    negativeCount++;

            return Math.Max(positiveCount, negativeCount);
        }
    }
}
