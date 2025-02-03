namespace LeetCode.Easy
{
    internal static class LongestStrictlyIncreasingOrStrictlyDecreasingSubarray
    {
        public static int LongestMonotonicSubarray(int[] nums)
        {
            int increasingCounter = 1,
                decreasingCounter = 1,
                incMax = 1,
                decMax = 1;

            for (int i = 1; i < nums.Length; i++)
                if (nums[i] > nums[i - 1])
                {
                    decMax = Math.Max(decMax, decreasingCounter);
                    decreasingCounter = 1;
                    increasingCounter++;
                }
                else if (nums[i] < nums[i - 1])
                {
                    incMax = Math.Max(incMax, increasingCounter);
                    increasingCounter = 1;
                    decreasingCounter++;
                }
                else
                {
                    incMax = Math.Max(incMax, increasingCounter);
                    decMax = Math.Max(decMax, decreasingCounter);
                    increasingCounter = 1;
                    decreasingCounter = 1;
                }

            incMax = Math.Max(incMax, increasingCounter);
            decMax = Math.Max(decMax, decreasingCounter);

            return Math.Max(incMax, decMax);
        }
    }
}
