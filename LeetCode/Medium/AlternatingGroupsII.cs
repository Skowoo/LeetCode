namespace LeetCode.Medium
{
    internal static class AlternatingGroupsII
    {
        public static int NumberOfAlternatingGroups(int[] colors, int k)
        {
            int left = 0,
                result = 0;

            for (int right = 0; right < colors.Length + k - 1; right++)
            {
                if (colors[right % colors.Length] == colors[(right + 1) % colors.Length])
                    left = right;

                if (right - left + 1 == k)
                {
                    result++;
                    left++;
                }
            }

            return result;
        }
    }
}
