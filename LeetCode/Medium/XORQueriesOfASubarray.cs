namespace LeetCode.Medium
{
    class XORQueriesOfASubarray
    {
        public static int[] XorQueries(int[] arr, int[][] queries)
        {
            int[] result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int currResult = arr[queries[i][0]];
                for (int j = queries[i][0] + 1; j <= queries[i][1]; j++)
                    currResult ^= arr[j];

                result[i] = currResult;
            }
            return result;
        }
    }
}

// var result = XorQueries([4, 8, 2, 10], [[2, 3], [1, 3], [0, 0], [0, 3]]);