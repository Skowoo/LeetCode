namespace LeetCode.Medium
{
    internal class FindPolygonWithTheLargestPerimeter
    {

        public static long LargestPerimeter(int[] nums)
        {
            nums = nums.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentValue = nums[i];
                nums[i] = 0;

                long lefotverSum = nums.Select(x => (long)x).Sum();

                if (lefotverSum > currentValue)
                    return currentValue + lefotverSum;
            }

            return -1L;
        }
    }
}

//Console.WriteLine(LargestPerimeter(new int[] { 1, 12, 1, 2, 5, 50, 3 }));
