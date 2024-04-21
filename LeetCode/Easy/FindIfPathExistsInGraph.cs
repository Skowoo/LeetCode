namespace LeetCode.Easy
{
    internal class FindIfPathExistsInGraph
    {
        public static bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            Dictionary<int, List<int>> nodesNeighbours = new();
            bool[] visited = new bool[n];

            foreach (var edge in edges)
            {
                if (nodesNeighbours.ContainsKey(edge[0]))
                    nodesNeighbours[edge[0]].Add(edge[1]);
                else
                    nodesNeighbours.Add(edge[0], new List<int> { edge[1] });

                if (nodesNeighbours.ContainsKey(edge[1]))
                    nodesNeighbours[edge[1]].Add(edge[0]);
                else
                    nodesNeighbours.Add(edge[1], new List<int> { edge[0] });
            }

            Stack<int> nodes = new();
            nodes.Push(source);

            while (nodes.Count > 0)
            {
                int currentNode = nodes.Pop();

                if (visited[currentNode])
                    continue;

                visited[currentNode] = true;

                if (currentNode == destination)
                    return true;

                foreach (int next in nodesNeighbours[currentNode])
                    nodes.Push(next);
            }

            return false;
        }
    }
}
