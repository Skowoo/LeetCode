namespace LeetCode.Medium
{
    internal class PathWithMaximumGold
    {
        public static int GetMaximumGold(int[][] grid)
        {
            int result = 0,
                height = grid.Length,
                width = grid[0].Length;

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    if (grid[i][j] > 0)
                        result = Math.Max(result, Recurse(i, j));

            int Recurse(int i, int j)
            {
                if (i < 0 || i >= height || j < 0 || j >= width || grid[i][j] == 0)
                    return 0;

                int gold = grid[i][j];
                grid[i][j] = 0;

                int currentMax = 0;
                currentMax = Math.Max(currentMax, gold + Recurse(i + 1, j));
                currentMax = Math.Max(currentMax, gold + Recurse(i - 1, j));
                currentMax = Math.Max(currentMax, gold + Recurse(i, j + 1));
                currentMax = Math.Max(currentMax, gold + Recurse(i, j - 1));

                grid[i][j] = gold;

                return currentMax;
            }

            return result;
        }
    }
}
