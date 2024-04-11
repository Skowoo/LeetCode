namespace LeetCode.Medium
{
    internal class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;

            foreach (int x in nums)
            {
                currentSum += x;
                maxSum = Math.Max(maxSum, currentSum);
                if (currentSum < 0)
                    currentSum = 0;
            }
            return maxSum;
        }
    }
}
