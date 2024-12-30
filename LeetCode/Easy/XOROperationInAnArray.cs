namespace LeetCode.Easy
{
    internal static class XorOperationInAnArray
    {
        public static int XorOperation(int n, int start)
        {
            int result = start;

            for (int i = 1; i < n; i++)
                result ^= start + 2 * i;

            return result;
        }
    }
}
