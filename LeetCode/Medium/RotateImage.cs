namespace LeetCode.Medium
{
    internal static class RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
                for (int j = i; j < matrix[i].Length; j++)
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);

            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length / 2; j++)
                    (matrix[i][j], matrix[i][^(j + 1)]) = (matrix[i][^(j + 1)], matrix[i][j]);
        }
    }
}
