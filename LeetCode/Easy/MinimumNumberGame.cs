namespace LeetCode.Easy
{
    internal static class MinimumNumberGame
    {
        public static int[] NumberGame(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i += 2)
                (nums[i - 1], nums[i]) = (nums[i], nums[i - 1]);
            return nums;
        }
    }
}
