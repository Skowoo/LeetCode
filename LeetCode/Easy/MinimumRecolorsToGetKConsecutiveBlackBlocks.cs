namespace LeetCode.Easy
{
    internal static class MinimumRecolorsToGetKConsecutiveBlackBlocks
    {
        public static int MinimumRecolors(string blocks, int k)
        {
            int whiteCount = 0;

            for (int i = 0; i < k; i++)
                if (blocks[i] == 'W')
                    whiteCount++;

            int result = whiteCount;

            for (int i = k; i < blocks.Length; i++)
            {
                if (blocks[i] == 'W')
                    whiteCount++;

                if (blocks[i - k] == 'W')
                    whiteCount--;

                result = Math.Min(result, whiteCount);
            }

            return result;
        }
    }
}
