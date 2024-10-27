namespace LeetCode.Medium
{
    internal class CountSquareSubmatricesWithAllOnes
    {
        public int CountSquares(int[][] matrix)
        {
            int result = 0;

            for (int i = 0; i < matrix.Length; ++i)
                for (int j = 0; j < matrix[0].Length; ++j)
                {
                    if (matrix[i][j] > 0 && i > 0 && j > 0)
                        matrix[i][j] = Math.Min(matrix[i - 1][j - 1], Math.Min(matrix[i - 1][j], matrix[i][j - 1])) + 1;

                    result += matrix[i][j];
                }

            return result;
        }
    }
}
