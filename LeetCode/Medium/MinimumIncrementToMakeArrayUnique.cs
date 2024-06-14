namespace LeetCode.Medium
{
    internal class MinimumIncrementToMakeArrayUnique
    {
        public static int MinIncrementForUnique(int[] nums)
        {
            int result = 0;

            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] <= nums[i - 1])
                {
                    int value = nums[i - 1] - nums[i] + 1;
                    nums[i] += value;
                    result += value;
                }

            return result;
        }
    }
}
