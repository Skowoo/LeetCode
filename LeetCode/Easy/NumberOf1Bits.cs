namespace LeetCode.Easy
{
    internal class NumberOf1Bits
    {
        public static int HammingWeight(int n)
        {
            int result = 0;
            while (n > 0)
            {
                result += n & 1;
                n >>= 1;
            }

            return result;
        }
    }
}
