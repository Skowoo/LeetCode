namespace LeetCode.Medium
{
    internal class LongestContinuousSubarrayWithAbsoluteDiffLessThanOrEqualToLimit
    {
        public static int LongestSubarray(int[] nums, int limit)
        {
            LinkedList<int> max = new(),
                            min = new();

            int left = 0,
                right = 0,
                result = 0;

            while (right < nums.Length)
            {
                while (max.Count > 0 && nums[max.Last!.Value] <= nums[right])
                    max.RemoveLast();

                max.AddLast(right);

                while (min.Count > 0 && nums[min.Last!.Value] >= nums[right])
                    min.RemoveLast();

                min.AddLast(right);

                while (nums[max.First!.Value] - nums[min.First!.Value] > limit)
                {
                    left++;
                    if (max.First.Value < left)
                        max.RemoveFirst();

                    if (min.First.Value < left)
                        min.RemoveFirst();
                }

                result = Math.Max(result, right - left + 1);
                right++;
            }

            return result;
        }
    }
}

//Console.WriteLine(LongestSubarray([8, 2, 4, 7], 4));
//Console.WriteLine(LongestSubarray([10, 1, 2, 4, 7, 2], 5));
//Console.WriteLine(LongestSubarray([4, 2, 2, 2, 4, 4, 2, 2], 0));