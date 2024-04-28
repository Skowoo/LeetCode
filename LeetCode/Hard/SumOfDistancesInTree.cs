namespace LeetCode.Hard
{
    internal class SumOfDistancesInTree
    {
        public static int[] SumOfDistancesInTree_Func(int n, int[][] edges)
        {
            var adjacencyMatrix = new List<int>[n]
                .Select(x => x = new List<int>())
                .ToArray();

            int[] result = new int[n];
            int[] auxCount = new int[n];

            foreach (var e in edges)
            {
                adjacencyMatrix[e[0]].Add(e[1]);
                adjacencyMatrix[e[1]].Add(e[0]);
            }

            Recurse(0, -1);
            void Recurse(int node, int previousNode)
            {
                foreach (var c in adjacencyMatrix[node])
                {
                    if (c == previousNode)
                        continue;

                    Recurse(c, node);
                    auxCount[node] += auxCount[c];
                    result[node] += result[c] + auxCount[c];
                }

                auxCount[node]++;
            }

            RecurseAgain(0, -1);
            void RecurseAgain(int node, int previousNode)
            {
                foreach (var c in adjacencyMatrix[node])
                {
                    if (c == previousNode)
                        continue;

                    result[c] = result[node] - auxCount[c] + n - auxCount[c];
                    RecurseAgain(c, node);
                }
            }

            return result;
        }
    }
}
