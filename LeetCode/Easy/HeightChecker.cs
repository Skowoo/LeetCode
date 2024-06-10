namespace LeetCode.Easy
{
    internal class HeightChecker
    {
        public int HeightChecker_Fnc(int[] heights)
        {
            int[] expected = new int[heights.Length];
            Array.Copy(heights, expected, heights.Length);
            Array.Sort(expected);
            int result = 0;
            for (int i = 0; i < heights.Length; i++)
                if (heights[i] != expected[i])
                    result++;

            return result;
        }
    }
}
