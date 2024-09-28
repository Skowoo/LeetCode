namespace LeetCode.Medium
{
    internal class MinimumHeightTrees
    {
        public static IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            Dictionary<int, HashSet<int>> nodesLevels = new();
            for (int i = 0; i < n; i++)
                nodesLevels.Add(i, new HashSet<int>());

            foreach (var edge in edges)
            {
                nodesLevels[edge[0]].Add(edge[1]);
                nodesLevels[edge[1]].Add(edge[0]);
            }

            int[] nodesDegrees = new int[n];
            Queue<int> leafNodes = new();
            foreach (var node in nodesLevels)
            {
                nodesDegrees[node.Key] = node.Value.Count;
                if (node.Value.Count == 1)
                    leafNodes.Enqueue(node.Key);
            }

            while (n > 2)
            {
                int size = leafNodes.Count;
                n -= size;
                for (int i = 0; i < size; i++)
                {
                    int node = leafNodes.Dequeue();
                    foreach (var neighbor in nodesLevels[node])
                    {
                        nodesDegrees[neighbor]--;
                        if (nodesDegrees[neighbor] == 1)
                            leafNodes.Enqueue(neighbor);
                    }
                }
            }

            return new List<int>(leafNodes.Count > 0 ? leafNodes : new int[] { 0 });
        }
    }
}

//var res = FindMinHeightTrees(4, new int[][] { new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1, 3 } });
//foreach (int i in res)
//    Console.WriteLine(i);