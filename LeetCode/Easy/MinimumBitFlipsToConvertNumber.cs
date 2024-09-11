namespace LeetCode.Easy
{
    internal class MinimumBitFlipsToConvertNumber
    {
        public int MinBitFlips(int start, int goal) => int.PopCount(start ^ goal);
    }
}
