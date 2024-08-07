namespace LeetCode.Hard
{
    internal class BuildAMatrixWithConditions
    {
        public static int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
        {
            var rows = Sort(k, rowConditions);
            if (rows is null)
                return [];

            var cols = Sort(k, colConditions);
            if (cols is null)
                return [];

            int[][] result = new int[k][];
            for (int i = 0; i < k; i++)
                result[i] = new int[k];

            Dictionary<int, int> tmpLookup = [];
            for (int i = 0; i < k; i++)
                tmpLookup.Add(cols[i], i);

            for (int i = 0; i < k; i++)
            {
                int j = tmpLookup[rows[i]];
                result[i][j] = rows[i];
            }

            return result;

            int[]? Sort(int k, int[][] conditions)
            {
                Dictionary<int, List<int>> adjMatrix = [];
                for (int i = 1; i <= k; i++)
                    adjMatrix.Add(i, []);

                foreach (int[] condition in conditions)
                    adjMatrix[condition[1]].Add(condition[0]);

                bool[] seenDfs = new bool[k + 1];
                for (int i = 1; i <= k; i++)
                {
                    if (HaveCycle(i, adjMatrix, seenDfs, new bool[k + 1]))
                        return null;
                }

                int[] InDegree = new int[k + 1];
                foreach (int[] condition in conditions)
                    InDegree[condition[0]] += 1;

                Queue<int> topoQueue = new();
                for (int i = 1; i <= k; i++)
                {
                    if (InDegree[i] == 0)
                        topoQueue.Enqueue(i);
                }

                int resultIndex = k - 1;
                int[] result = new int[k];
                while (topoQueue.Count > 0)
                {
                    int node = topoQueue.Dequeue();
                    result[resultIndex--] = node;

                    foreach (int adjNode in adjMatrix[node])
                    {
                        InDegree[adjNode] -= 1;
                        if (InDegree[adjNode] == 0)
                            topoQueue.Enqueue(adjNode);
                    }
                }

                return result;
            }

            bool HaveCycle(int node, Dictionary<int, List<int>> adjList, bool[] seenDfs, bool[] seen)
            {
                if (seen[node])
                    return true;

                if (seenDfs[node])
                    return false;

                seen[node] = true;
                seenDfs[node] = true;

                bool isCycle = false;
                foreach (int nd in adjList[node])
                    isCycle = isCycle | HaveCycle(nd, adjList, seenDfs, seen);

                seen[node] = false;
                return isCycle;
            }
        }
    }
}
