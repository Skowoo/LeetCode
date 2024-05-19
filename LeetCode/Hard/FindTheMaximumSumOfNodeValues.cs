namespace LeetCode.Hard
{
    internal class FindTheMaximumSumOfNodeValues
    {
        public static long MaximumValueSum(int[] nums, int k, int[][] edges)
        {
            long result = 0;
            bool singleChange = false;
            int minDiff = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                minDiff = Math.Min(minDiff, Math.Abs(nums[i] - (nums[i] ^ k)));
                if ((nums[i] ^ k) > nums[i])
                {
                    result += nums[i] ^ k;
                    singleChange = !singleChange;
                }
                else
                {
                    result += nums[i];
                }
            }
            return singleChange ? result - minDiff : result;
        }
    }
}
