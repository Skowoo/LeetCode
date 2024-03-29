namespace LeetCode.Medium
{
    internal class CountSubarraysWhereMaxElementAppearsAtLeastKTimes
    {
        public static long CountSubarrays(int[] nums, int k)
        {
            long result = 0L;
            int leftPointer = 0,
                rightPointer = 0,
                maxValue = nums.Max(),
                maxCounter = 0;

            while (rightPointer < nums.Length)
            {
                if (nums[rightPointer] == maxValue)
                    maxCounter++;

                while (maxCounter >= k)
                {
                    if (nums[leftPointer] == maxValue)
                        maxCounter--;

                    leftPointer++;
                }

                result += leftPointer;
                rightPointer++;
            }
            return result;
        }
    }
}
