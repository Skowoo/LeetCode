namespace LeetCode.Easy
{
    internal class LargestLocalValuesInAMatrix
    {
        public static int[][] LargestLocal(int[][] grid)
        {
            int[][] result = new int[grid.Length - 2][];
            for (int i = 0; i < result.Length; i++)
                result[i] = new int[grid.Length - 2];

            for (int i = 1; i < grid.Length - 1; i++)
                for (int j = 1; j < grid[i].Length - 1; j++)
                    for (int k = i - 1; k <= i + 1; k++)
                        for (int l = j - 1; l <= j + 1; l++)
                            if (grid[k][l] > result[i - 1][j - 1])
                                result[i - 1][j - 1] = grid[k][l];

            return result;
        }
    }
}
