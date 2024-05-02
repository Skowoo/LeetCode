namespace LeetCode.Easy
{
    internal class LargestPositiveIntegerThatExistsWithItsNegative
    {
        public static int FindMaxK(int[] nums)
        {
            Array.Sort(nums);

            int left = 0,
                right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] < 0 && Math.Abs(nums[left]) == nums[right])
                    return nums[right];
                else if (Math.Abs(nums[left]) > nums[right])
                    left++;
                else
                    right--;
            }

            return -1;
        }
    }
}
