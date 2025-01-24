namespace LeetCode.Easy
{
    internal static class SumOfVariableLengthSubarrays
    {
        public static int SubarraySum(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
                for (int start = Math.Max(0, i - nums[i]); start <= i; start++)
                    result += nums[start];
            return result;
        }
    }
}
