namespace LeetCode.Easy
{
    internal class IslandPerimeter
    {
        public static int IslandPerimeter_func(int[][] grid)
        {
            int result = 0;

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] == 1)
                    {
                        result += 4;
                        if (i < (grid.Length - 1) && grid[i + 1][j] == 1)
                            result--;
                        if (i > 0 && grid[i - 1][j] == 1)
                            result--;
                        if (j < (grid[i].Length - 1) && grid[i][j + 1] == 1)
                            result--;
                        if (j > 0 && grid[i][j - 1] == 1)
                            result--;
                    }

            return result;
        }
    }
}
