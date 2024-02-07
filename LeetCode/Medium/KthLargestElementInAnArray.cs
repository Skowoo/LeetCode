namespace LeetCode.Medium
{
    internal class KthLargestElementInAnArray
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            return nums.OrderByDescending(x => x).Skip(k).Take(1).Single();
        }
    }
}
