namespace LeetCode.Medium
{
    internal class MinimumCostToConvertStringI
    {
        public static long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
        {
            int[,] costs = new int[26, 26];
            for (int i = 0; i < original.Length; i++)
            {
                int src = original[i] - 97, trg = changed[i] - 97;
                if (costs[src, trg] == 0 || costs[src, trg] > cost[i])
                    costs[src, trg] = cost[i];
            }

            for (int i = 0; i < 26; i++)
                for (int j = 0; j < 26; j++)
                    for (int k = 0; k < 26; k++)
                        if (i == j || i == k || j == k || costs[j, i] == 0 || costs[i, k] == 0)
                            continue;
                        else if (costs[j, k] == 0 || costs[j, k] > costs[j, i] + costs[i, k])
                            costs[j, k] = costs[j, i] + costs[i, k];

            long result = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == target[i])
                    continue;

                int distance = costs[source[i] - 97,
                    target[i] - 97];

                if (distance == 0)
                    return -1;

                result += distance;
            }

            return result;
        }
    }
}
