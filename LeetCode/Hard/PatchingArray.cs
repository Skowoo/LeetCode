namespace LeetCode.Hard
{
    internal class PatchingArray
    {
        public static int MinPatches(int[] nums, int n)
        {
            int result = 0,
                indexer = 0;
            long target = 1;

            while (target <= n)
            {
                if (indexer < nums.Length && nums[indexer] <= target)
                    target += nums[indexer++];
                else
                {
                    target += target;
                    result++;
                }
            }
            return result;
        }
    }
}
