namespace LeetCode.Medium
{
    internal class MaximumTotalImportanceOfRoads
    {
        public static long MaximumImportance(int n, int[][] roads)
        {
            int[] weights = new int[n];
            foreach (var road in roads)
                foreach (var city in road)
                    weights[city]++;

            var indexes = Enumerable.Range(0, n).ToArray();
            Array.Sort(indexes, (a, b) => weights[b].CompareTo(weights[a]));

            int[] totalValue = new int[n];
            for (int i = 0; i < n; i++)
                totalValue[indexes[i]] = n - i;

            long result = 0;
            foreach (var road in roads)
                result += totalValue[road[0]] + totalValue[road[1]];

            return result;
        }
    }
}
