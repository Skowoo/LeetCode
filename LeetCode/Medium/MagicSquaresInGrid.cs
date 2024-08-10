namespace LeetCode.Medium
{
    internal class MagicSquaresInGrid
    {
        public static int NumMagicSquaresInside(int[][] grid)
        {
            int result = 0;

            if (grid.Length < 3 || grid[0].Length < 3)
                return result;

            for (int i = 0; i < grid.Length - 2; i++)
                for (int j = 0; j < grid[0].Length - 2; j++)
                    if (CheckGrid(i, j))
                        result++;

            return result;

            bool CheckGrid(int i, int j)
            {
                if (!(grid[i][j] + grid[i][j + 1] + grid[i][j + 2] == 15 &&
                    grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2] == 15 &&
                    grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] == 15 &&

                    grid[i][j] + grid[i + 1][j] + grid[i + 2][j] == 15 &&
                    grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1] == 15 &&
                    grid[i][j + 2] + grid[i + 1][j + 2] + grid[i + 2][j + 2] == 15 &&

                    grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2] == 15 &&
                    grid[i][j + 2] + grid[i + 1][j + 1] + grid[i + 2][j] == 15 &&
                    grid[i + 1][j + 1] != grid[i][j]))
                    return false;

                for (int x = i; x < i + 3; x++)
                    for (int y = j; y < j + 3; y++)
                        if (grid[x][y] < 1 || grid[x][y] > 9)
                            return false;

                return true;
            }
        }
    }
}
