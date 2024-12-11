namespace LeetCode.Easy
{
    internal static class PositionsOfLargeGroups
    {
        public static IList<IList<int>> LargeGroupPositions(string s)
        {
            List<IList<int>> result = [];
            int i = 0;

            while (i < s.Length)
            {
                int firstCharIndex = i;

                while (i < s.Length && s[i] == s[firstCharIndex])
                    i++;

                if (i - firstCharIndex >= 3)
                    result.Add([firstCharIndex, i - 1]);
            }

            return result;
        }
    }
}
