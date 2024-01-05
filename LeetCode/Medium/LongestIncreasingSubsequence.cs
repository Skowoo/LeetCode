namespace LeetCode.Medium
{
    internal class LongestIncreasingSubsequence
    {
        public static int LengthOfLIS(int[] nums)
        {
            int[] auxArray = Enumerable.Repeat(1, nums.Length).ToArray();

            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < i; j++)
                    if (nums[i] > nums[j])
                        auxArray[i] = Math.Max(auxArray[i], 1 + auxArray[j]);

            return auxArray.Max();
        }
    }
}
