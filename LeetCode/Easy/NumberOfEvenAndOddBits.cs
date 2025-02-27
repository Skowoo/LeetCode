namespace LeetCode.Easy
{
    internal static class NumberOfEvenAndOddBits
    {
        public static int[] EvenOddBit(int n)
        {
            string binaryReversed = new([.. Convert.ToString(n, 2).Reverse()]);
            int odd = 0,
                even = 0;

            for (int i = 0; i < binaryReversed.Length; i++)
                if (i % 2 == 0 && binaryReversed[i] == '1')
                    even++;
                else if (binaryReversed[i] == '1')
                    odd++;

            return [even, odd];
        }
    }
}
