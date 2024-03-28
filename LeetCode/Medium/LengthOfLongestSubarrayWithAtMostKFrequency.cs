namespace LeetCode.Medium
{
    internal class LengthOfLongestSubarrayWithAtMostKFrequency
    {
        public static int MaxSubarrayLength(int[] nums, int k)
        {
            int maxLength = 1, leftPointer = 0;
            Dictionary<int, int> numbersCounter = new();

            for (int rightPointer = 0; rightPointer < nums.Length; rightPointer++)
            {
                if (numbersCounter.ContainsKey(nums[rightPointer]))
                    numbersCounter[nums[rightPointer]]++;
                else
                    numbersCounter.Add(nums[rightPointer], 1);

                while (numbersCounter[nums[rightPointer]] > k)
                {
                    numbersCounter[nums[leftPointer]]--;
                    leftPointer++;
                }
                maxLength = Math.Max(maxLength, rightPointer - leftPointer + 1);
            }
            return maxLength;
        }
    }
}
