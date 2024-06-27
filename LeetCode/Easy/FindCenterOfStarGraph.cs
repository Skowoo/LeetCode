namespace LeetCode.Easy
{
    internal class FindCenterOfStarGraph
    {
        public static int FindCenter(int[][] edges)
        {
            if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
                return edges[0][0];
            else
                return edges[0][1];
        }

        // LINQ solution
        public static int FindCenter_LINQ(int[][] edges) => edges[0].Intersect(edges[1]).Single();
    }
}
