namespace LeetCode.Hard
{
    internal class MinimumNumberOfKConsecutiveBitFlips
    {
        public static int MinKBitFlips(int[] nums, int k)
        {
            int result = 0,
                switchCounter = 0;
            int[] switched = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i >= k)
                    switchCounter ^= switched[i - k];

                if (nums[i] == switchCounter % 2)
                {
                    if (i + k > nums.Length)
                        return -1;

                    switched[i] = 1;
                    switchCounter ^= 1;
                    result++;
                }
            }

            return result;
        }
    }
}
