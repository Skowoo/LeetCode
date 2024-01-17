namespace LeetCode.Easy
{
    internal class UniqueNumberOfOccurencies
    {

        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> occurencies = new();

            foreach (int i in arr)
                if (occurencies.ContainsKey(i))
                    occurencies[i]++;
                else
                    occurencies.Add(i, 1);

            return occurencies.Values.Count == occurencies.Values.Distinct().Count();
        }
    }
}
