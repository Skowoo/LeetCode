namespace LeetCode
{
    internal static class DecompressRunLengthEncodedList
    {
        public static int[] DecompressRLElist(int[] nums)
        {
            List<int> result = [];

            for (int i = 0; i < nums.Length; i += 2)
                for (int j = 0; j < nums[i]; j++)
                    result.Add(nums[i + 1]);

            return [.. result];
        }
    }
}
