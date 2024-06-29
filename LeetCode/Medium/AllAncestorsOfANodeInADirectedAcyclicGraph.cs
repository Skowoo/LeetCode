namespace LeetCode.Medium
{
    internal class AllAncestorsOfANodeInADirectedAcyclicGraph
    {
        public static IList<IList<int>> GetAncestors(int n, int[][] edges)
        {
            HashSet<int>[] ancestors = new HashSet<int>[n];
            for (int i = 0; i < n; i++)
                ancestors[i] = [];

            foreach (int[] edge in edges)
                ancestors[edge[1]].Add(edge[0]);

            for (int i = 0; i < n; i++)
            {
                Dictionary<int, int> visited = [];
                Queue<int> bfsQueue = new();
                foreach (int a in ancestors[i])
                {
                    if (!visited.ContainsKey(a))
                    {
                        visited[a] = 1;
                        bfsQueue.Enqueue(a);
                    }
                }
                while (bfsQueue.Count > 0)
                {
                    int ancestor = bfsQueue.Dequeue();
                    ancestors[i].Add(ancestor);
                    foreach (int a in ancestors[ancestor])
                    {
                        if (!visited.ContainsKey(a))
                        {
                            visited[a] = 1;
                            bfsQueue.Enqueue(a);
                        }
                    }
                }
            }

            int[][] result = new int[n][];

            for (int i = 0; i < n; i++)
            {
                List<int> tempList = new(ancestors[i]);
                tempList.Sort();
                result[i] = [.. tempList];
            }

            return result;
        }
    }
}
