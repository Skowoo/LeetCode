namespace LeetCode.Medium
{
    internal static class SpecialArrayII
    {
        public static bool[] IsArraySpecial(int[] nums, int[][] queries)
        {
            int[] maxReach = new int[nums.Length];
            int maxIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                maxIndex = Math.Max(maxIndex, i);
                while (maxIndex < nums.Length - 1 && (nums[maxIndex] % 2 != nums[maxIndex + 1] % 2))
                    maxIndex++;

                maxReach[i] = maxIndex;
            }

            bool[] result = new bool[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                int startIndex = queries[i][0],
                    endIndex = queries[i][1];
                result[i] = endIndex <= maxReach[startIndex];
            }

            return result;
        }
    }
}
