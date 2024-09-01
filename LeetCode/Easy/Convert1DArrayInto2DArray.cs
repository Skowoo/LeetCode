namespace LeetCode.Easy
{
    class Convert1DArrayInto2DArray
    {
        public static int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (m * n != original.Length)
                return [];

            int[][] result = new int[m][];
            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                    result[i][j] = original[i * n + j];
            }

            return result;
        }
    }
}

// Console.WriteLine(Construct2DArray([1,2,3,4,5,6,7,8,9,10,11,12], 4, 3));