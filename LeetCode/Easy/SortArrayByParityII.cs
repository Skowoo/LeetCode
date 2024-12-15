namespace LeetCode.Easy
{
    internal static class SortArrayByParityII
    {
        public static int[] SortArrayByParityII_Func(int[] nums)
        {
            int oddIndex = 1,
                evenIndex = 0;

            int[] result = new int[nums.Length];

            foreach (int i in nums)
                if (i % 2 == 0)
                {
                    result[evenIndex] = i;
                    evenIndex += 2;
                }
                else
                {
                    result[oddIndex] = i;
                    oddIndex += 2;
                }

            return result;
        }
    }
}
