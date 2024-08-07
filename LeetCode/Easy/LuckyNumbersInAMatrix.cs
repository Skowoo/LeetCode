namespace LeetCode.Easy
{
    internal class LuckyNumbersInAMatrix
    {
        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            List<int> result = [];
            for (int i = 0; i < matrix.Length; i++)
            {
                int minRow = int.MaxValue;
                int colIndex = 0;
                for (int j = 0; j < matrix[i].Length; j++)
                    if (matrix[i][j] < minRow)
                    {
                        minRow = matrix[i][j];
                        colIndex = j;
                    }

                int maxCol = int.MinValue;
                for (int j = 0; j < matrix.Length; j++)
                    if (matrix[j][colIndex] > maxCol)
                        maxCol = matrix[j][colIndex];

                if (minRow == maxCol)
                    result.Add(minRow);
            }

            return [.. result];
        }
    }
}

//Console.WriteLine(LuckyNumbers([[3, 7, 8], [9, 11, 13], [15, 16, 17]]));
//Console.WriteLine(LuckyNumbers([[1, 10, 4, 2], [9, 3, 8, 7], [15, 16, 17, 12]]));
//Console.WriteLine(LuckyNumbers([[7, 8], [1, 2]]));