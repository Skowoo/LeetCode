namespace LeetCode.Medium
{
    internal static class CountServersThatCommunicate
    {
        public static int CountServers(int[][] grid)
        {
            int result = 0;
            int[] rowCounter = new int[grid.Length];
            int[] colCounter = new int[grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == 1)
                    {
                        rowCounter[i]++;
                        colCounter[j]++;
                    }

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == 1 && (rowCounter[i] > 1 || colCounter[j] > 1))
                        result++;

            return result;
        }
    }
}
