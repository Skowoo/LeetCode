namespace LeetCode.Hard
{
    internal class SecondMinimumTimeToReachDestination
    {
        public static int SecondMinimum(int n, int[][] edges, int time, int change)
        {
            List<int>[] graph = new List<int>[n + 1];
            (int first, int second)[] distances = new (int, int)[n + 1];

            for (int i = 1; i <= n; i++)
            {
                graph[i] = [];
                distances[i] = (int.MaxValue, int.MaxValue);
            }

            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            Queue<(int, int)> queue = new();
            queue.Enqueue((1, 0));
            distances[1] = (0, int.MaxValue);

            while (queue.Count > 0)
            {
                int currentSize = queue.Count;

                for (int i = 0; i < currentSize; i++)
                {
                    (int curr, int curTime) = queue.Dequeue();

                    foreach (var node in graph[curr])
                    {
                        bool isGreen = ((curTime / change) % 2 == 0);
                        int newTime = curTime + time + (isGreen ? 0 : (change - curTime % change));

                        if (distances[node].first == int.MaxValue)
                        {
                            distances[node].first = newTime;
                            queue.Enqueue((node, newTime));
                        }
                        else if (newTime > distances[node].first && distances[node].second == int.MaxValue)
                        {
                            distances[node].second = newTime;
                            queue.Enqueue((node, newTime));
                        }
                    }
                }
            }

            return distances[n].second;
        }
    }
}
