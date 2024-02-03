namespace LeetCode.Medium
{
    internal class PartitionArrayForMaximumSum
    {
        public static int MaxSumAfterPartitioning(int[] arr, int k)
        {
            int[] dp = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                int tempMaxValue = 0;
                int tempSum = 0;

                for (int j = i; j > Math.Max(-1, i - k); j--)
                {
                    if (tempMaxValue < arr[j])
                        tempMaxValue = arr[j];

                    int currentSum = tempMaxValue * (i - j + 1) + dp[j];

                    if (tempSum < currentSum)
                        tempSum = currentSum;
                }
                dp[i + 1] = tempSum;
            }

            return dp.Last();
        }
    }
}

//int[] test = { 1, 15, 7, 9, 2, 5, 10 };
//Console.WriteLine($"{MaxSumAfterPartitioning(test, 3)} / 84");
//Console.WriteLine(MaxSumAfterPartitioning(test, 3) == 84);
//Console.WriteLine();

//int[] test3 = { 1, 4, 1, 5, 7, 3, 6, 1, 9, 9, 3 };
//Console.WriteLine($"{MaxSumAfterPartitioning(test3, 4)} / 83");
//Console.WriteLine(MaxSumAfterPartitioning(test3, 4) == 83);
//Console.WriteLine();

//int[] test2 = { 1 };
//Console.WriteLine($"{MaxSumAfterPartitioning(test2, 1)} / 1");
//Console.WriteLine(MaxSumAfterPartitioning(test2, 1) == 1);
//Console.WriteLine();
