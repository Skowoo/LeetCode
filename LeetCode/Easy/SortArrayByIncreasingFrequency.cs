namespace LeetCode.Easy
{
    internal class SortArrayByIncreasingFrequency
    {
        public static int[] FrequencySort(int[] nums)
        {
            Dictionary<int, int> frequency = [];
            foreach (var num in nums)
                if (frequency.TryGetValue(num, out int value))
                    frequency[num] = ++value;
                else
                    frequency[num] = 1;

            return [.. nums.OrderBy(x => frequency[x]).ThenByDescending(x => x)];
        }
    }
}
