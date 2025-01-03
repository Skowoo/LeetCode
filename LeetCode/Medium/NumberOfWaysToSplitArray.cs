namespace LeetCode.Medium
{
    internal static class NumberOfWaysToSplitArray
    {
        public static int WaysToSplitArray(int[] nums)
        {
            long totalSum = 0,
                currSum = 0;
            int result = 0;

            foreach (int x in nums)
                totalSum += x;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                currSum += nums[i];
                totalSum -= nums[i];

                if (currSum >= totalSum)
                    result++;
            }

            return result;
        }
    }
}
