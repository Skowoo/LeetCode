namespace LeetCode.Easy
{
    internal static class SingleNumber
    {
        public static int SingleNumberFunc(int[] nums)
        {
            int result = 0;
            foreach (int x in nums)
                result ^= x;

            return result;
        }
    }
}
