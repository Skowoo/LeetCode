namespace LeetCode.Easy
{
    internal static class CountSubarraysOfLengthThreeWithACondition
    {
        public static int CountSubarrays(int[] nums)
        {
            int result = 0;
            for (int i = 1; i < nums.Length - 1; i++)
                if ((nums[i - 1] + nums[i + 1]) * 2 == nums[i])
                    result++;

            return result;
        }
    }
}
