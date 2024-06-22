namespace LeetCode.Medium
{
    internal class CountNumberOfNiceSubarrays
    {
        public static int NumberOfSubarrays(int[] nums, int k)
        {
            int currSum = 0,
                result = 0;

            Dictionary<int, int> prefixDictionary = new(nums.Length) { [0] = 1 };

            foreach (int i in nums)
            {
                currSum += i & 1;

                if (prefixDictionary.ContainsKey(currSum - k))
                    result += prefixDictionary[currSum - k];

                prefixDictionary[currSum] = prefixDictionary.GetValueOrDefault(currSum, 0) + 1;
            }
            return result;
        }
    }
}
