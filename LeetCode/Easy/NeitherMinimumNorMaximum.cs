namespace LeetCode.Easy
{
    internal static class NeitherMinimumNorMaximum
    {
        public static int FindNonMinOrMax(int[] nums)
        {
            if (nums.Length < 3)
                return -1;

            Array.Sort(nums);
            return nums[1];
        }
    }
}
