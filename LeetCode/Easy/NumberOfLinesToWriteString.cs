namespace LeetCode.Easy
{
    internal class NumberOfLinesToWriteString
    {
        public static int[] NumberOfLines(int[] widths, string s)
        {
            int result = 0,
                currentLine = 0;

            foreach (var c in s)
            {
                if (currentLine + widths[c - 'a'] > 100)
                {
                    currentLine = 0;
                    result++;
                }
                currentLine += widths[c - 'a'];
            }

            return [result + 1, currentLine];
        }
    }
}
