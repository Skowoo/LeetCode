namespace LeetCode.Easy
{
    internal static class CellsWithOddValuesInAMatrix
    {
        public static int OddCells(int m, int n, int[][] indices)
        {
            int[,] baseMatrix = new int[m, n];

            foreach (var index in indices)
            {
                IncrementRow(baseMatrix, index[0]);
                IncrementColumn(baseMatrix, index[1]);
            }

            int result = 0;
            foreach (int i in baseMatrix)
                if (i % 2 == 1)
                    result++;

            return result;

            void IncrementRow(int[,] matrix, int rowNumber)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                    matrix[rowNumber, i]++;
            }

            void IncrementColumn(int[,] matrix, int colNumber)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    matrix[i, colNumber]++;
            }
        }
    }
}
