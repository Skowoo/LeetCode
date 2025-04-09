namespace LeetCode.Easy
{
    internal static class MinimumOperationsToMakeArrayValuesEqualToK
    {
        public static int MinOperations(int[] nums, int k)
        {
            HashSet<int> hashSet = [];
            foreach (int num in nums)
                if (num < k)
                    return -1;
                else if (num > k)
                    hashSet.Add(num);

            return hashSet.Count;
        }
    }
}
