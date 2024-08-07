namespace LeetCode.Medium
{
    internal class FindTheCityWithTheSmallestNumberOfNeighborsAtAThresholdDistance
    {
        public static int FindTheCity(int n, int[][] edges, int distanceThreshold)
        {
            int[,] distances = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i == j)
                        distances[i, j] = 0;
                    else
                        distances[i, j] = 20000;

            foreach (int[] edge in edges)
            {
                distances[edge[0], edge[1]] = edge[2];
                distances[edge[1], edge[0]] = edge[2];
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        if (distances[j, i] + distances[i, k] < distances[j, k])
                            distances[j, k] = distances[j, i] + distances[i, k];

            int minimum = int.MaxValue;
            int result = -1;

            for (int i = 0; i < n; i++)
            {
                int reachables = 0;
                for (int j = 0; j < n; j++)
                    if (distances[i, j] <= distanceThreshold)
                        reachables++;

                if (reachables <= minimum)
                {
                    minimum = reachables;
                    result = i;
                }
            }

            return result;
        }
    }
}
