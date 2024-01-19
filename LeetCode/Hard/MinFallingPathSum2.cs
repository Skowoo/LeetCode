namespace LeetCode.Hard
{
    internal class MinFallingPathSum2
    {
        public static int MinFallingPathSum(int[][] grid)
        {
            int size = grid.Length;

            if (size < 2)
                return grid[0][0];

            for (int i = 1; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    int minValue;
                    if (j == 0)
                        minValue = grid[i][j] + grid[i - 1][j + 1];
                    else
                        minValue = grid[i][j] + grid[i - 1][j - 1];

                    for (int k = 0; k < size; k++)
                        if (k != j && grid[i][j] + grid[i - 1][k] < minValue)
                            minValue = grid[i][j] + grid[i - 1][k];

                    grid[i][j] = minValue;
                }

            return grid[size - 1].Min();
        }
    }
}

// TestMain:
//static void Main()
//{
//    var arr = new int[][]
//    {
//                new int[] { -73,  61,  43, -48, -36 },
//                new int[] {  3,   30,  27,  57,  10 },
//                new int[] {  96, -76,  84,  59, -15, },
//                new int[] {   5, -49,  76,  31,  -7 },
//                new int[] {  97,  91,  61, -46,  67 }
//    };

//    Console.WriteLine(MinFallingPathSum(arr));

//    var arr2 = new int[][]
//    {
//                new int[] { 1, 2, 3 },
//                new int[] { 4, 5, 6 },
//                new int[] { 7, 8, 9,}
//    };
//    Console.WriteLine(MinFallingPathSum(arr2));
//}

        
//    }
