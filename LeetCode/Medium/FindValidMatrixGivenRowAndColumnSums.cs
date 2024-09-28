namespace LeetCode.Medium
{
    internal class FindValidMatrixGivenRowAndColumnSums
    {
        public static int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            int[][] result = new int[rowSum.Length][];
            for (int i = 0; i < rowSum.Length; i++)
            {
                result[i] = new int[colSum.Length];
                for (int j = 0; j < colSum.Length; j++)
                {
                    result[i][j] = Math.Min(rowSum[i], colSum[j]);
                    rowSum[i] -= result[i][j];
                    colSum[j] -= result[i][j];
                }
            }

            return result;
        }
    }
}
