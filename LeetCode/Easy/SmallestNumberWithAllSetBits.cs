namespace LeetCode.Easy
{
    internal static class SmallestNumberWithAllSetBits
    {
        public static int SmallestNumber(int n)
        {
            int result = 2;
            while (result - 1 < n)
                result *= 2;

            return result - 1;
        }
    }
}
