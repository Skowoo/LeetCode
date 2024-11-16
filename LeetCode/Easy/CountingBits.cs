namespace LeetCode.Easy
{
    internal static class CountingBits
    {
        public static int[] CountBits(int n)
        {
            var result = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                int count = 0,
                    num = i;

                while (num > 0)
                {
                    count += num & 1;
                    num >>= 1;
                }

                result[i] = count;
            }

            return result;
        }
    }
}
