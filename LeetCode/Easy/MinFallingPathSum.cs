namespace LeetCode.Easy
{
    internal class MinFallingPathSum
    {
        public static int MinFallingPathSumFunc(int[][] matrix)
        {
            int size = matrix.Length;

            if (size < 2)
                return matrix[0][0];

            int? leftSum, rightSum, centerSum;

            for (int i = 1; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    leftSum = null;
                    rightSum = null;
                    centerSum = null;

                    if (j != 0)
                        leftSum = matrix[i - 1][j - 1] + matrix[i][j];

                    centerSum = matrix[i - 1][j] + matrix[i][j];

                    if (j < size - 1)
                        rightSum = matrix[i - 1][j + 1] + matrix[i][j];

                    if (leftSum is not null && leftSum <= centerSum && (leftSum <= rightSum || rightSum is null))
                        matrix[i][j] = leftSum.Value;

                    if (centerSum is not null && (centerSum <= rightSum || rightSum is null) && (centerSum <= leftSum || leftSum is null))
                        matrix[i][j] = centerSum.Value;

                    if (rightSum is not null && rightSum <= centerSum && (rightSum <= leftSum || leftSum is null))
                        matrix[i][j] = rightSum.Value;
                }

            return matrix[size - 1].Min();
        }
    }
}
