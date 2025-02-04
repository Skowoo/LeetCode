namespace LeetCode.Easy
{
    internal static class MaximumAscendingSubarraySum
    {
        public static int MaxAscendingSum(int[] nums)
        {
            int maxSum = 0;
            int currSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    currSum += nums[i];
                else
                {
                    maxSum = Math.Max(maxSum, currSum);
                    currSum = nums[i];
                }
            }

            return Math.Max(maxSum, currSum);
        }
    }
}
