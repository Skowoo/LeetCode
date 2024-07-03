namespace LeetCode.Medium
{
    internal class MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves
    {
        public static int MinDifference(int[] nums)
        {
            if (nums.Length < 5)
                return 0;

            Array.Sort(nums);

            int result = int.MaxValue;

            for (int i = 0; i <= 3; i++)
                for (int j = nums.Length - 1; j >= nums.Length - 4 + i && i != j; j--)
                    result = Math.Min(result, nums[j] - nums[i]);

            return result;
        }
    }
}
