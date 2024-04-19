namespace LeetCode.Medium
{
    internal class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            int result = 0;
            bool[,] marked = new bool[grid.Length, grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == '1' && !marked[i, j])
                    {
                        result++;
                        Recurse(i, j);
                    }

            void Recurse(int i, int j)
            {
                if (marked[i, j] || grid[i][j] != '1')
                    return;

                marked[i, j] = true;

                if (i > 0)
                    Recurse(i - 1, j);
                if (i < grid.Length - 1)
                    Recurse(i + 1, j);
                if (j > 0)
                    Recurse(i, j - 1);
                if (j < grid[0].Length - 1)
                    Recurse(i, j + 1);
            }

            return result;
        }
    }
}
