namespace LeetCode.Easy
{
    internal static class SortArrayByParity
    {
        public static int[] SortArrayByParityFunc(int[] nums) => nums.Where(x => x % 2 == 0).Concat(nums.Where(x => x % 2 == 1)).ToArray();
    }
}
