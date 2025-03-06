namespace LeetCode.Easy
{
    internal static class FindMissingAndRepeatedValues
    {
        public static int[] FindMissingAndRepeatedValues_Func(int[][] grid)
        {
            HashSet<int> numbers = [];
            int totalSum = 0;
            int[] result = new int[2];
            foreach (var a in grid)
                foreach (int num in a)
                {
                    if (numbers.TryGetValue(num, out int outValue))
                    {
                        result[0] = outValue;
                    }
                    else
                    {
                        totalSum += num;
                        numbers.Add(num);
                    }
                }

            int n = grid.Length * grid[0].Length;
            int expectedSum = (n * (n + 1)) / 2;
            result[1] = expectedSum - totalSum;

            return result;
        }
    }
}
