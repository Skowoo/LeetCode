namespace LeetCode.Hard
{
    internal class CountSubarraysWithFixedBounds
    {
        public static long CountSubarrays(int[] nums, int minK, int maxK)
        {
            long answer = 0;

            int minValIndex = -1,
                maxValIndex = -1,
                lastBadIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == minK)
                    minValIndex = i;
                if (nums[i] == maxK)
                    maxValIndex = i;
                if (nums[i] < minK || nums[i] > maxK)
                    lastBadIndex = i;

                answer += Math.Max(0, Math.Min(maxValIndex, minValIndex) - lastBadIndex);
            }

            return answer;
        }
    }
}
