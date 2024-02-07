namespace LeetCode.Medium
{
    internal class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numberFrequency = new();

            foreach (int i in nums)
                if (numberFrequency.ContainsKey(i))
                    numberFrequency[i]++;
                else
                    numberFrequency.Add(i, 1);

            return numberFrequency.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        }
    }
}
