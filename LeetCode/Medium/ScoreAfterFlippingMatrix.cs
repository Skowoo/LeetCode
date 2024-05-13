namespace LeetCode.Medium
{
    internal class ScoreAfterFlippingMatrix
    {
        public static int MatrixScore(int[][] grid)
        {
            int score = grid.Length;
            for (int c = 1; c < grid[0].Length; c++)
            {
                int count = 0;
                for (int r = 0; r < grid.Length; r++)
                {
                    var row = grid[r];
                    count += 1 ^ row[0] ^ row[c];
                }
                score = (score << 1) + Math.Max(count, grid.Length - count);
            }
            return score;
        }
    }
}
