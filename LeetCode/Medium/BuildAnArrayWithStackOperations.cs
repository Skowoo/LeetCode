namespace LeetCode.Medium
{
    internal static class BuildAnArrayWithStackOperations
    {
        public static IList<string> BuildArray(int[] target, int n)
        {
            HashSet<int> hashSet = new(target);
            List<string> result = [];

            for (int i = 0; i < target[^1]; i++)
            {
                result.Add("Push");

                if (!hashSet.Contains(i + 1))
                    result.Add("Pop");
            }

            return result;
        }
    }
}
