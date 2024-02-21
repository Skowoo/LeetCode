namespace LeetCode.Medium
{
    internal class BitwiseANDofNumbersRange
    {
        public static int RangeBitwiseAnd(int left, int right)
        {
            while (left < right)
                right &= (right - 1);

            return left & right;
        }
    }
}
