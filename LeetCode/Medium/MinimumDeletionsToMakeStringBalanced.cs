namespace LeetCode.Medium
{
    internal class MinimumDeletionsToMakeStringBalanced
    {
        public static int MinimumDeletions(string s)
        {
            int result = 0,
                aCounter = 0;

            foreach (var c in s.Reverse())
                if (c == 'a')
                    aCounter++;
                else
                    result = Math.Min(result + 1, aCounter);

            return result;
        }
    }
}
