namespace LeetCode.Medium
{
    internal class Subsets
    {
        public static IList<IList<int>> Subsets_Func(int[] nums)
        {
            List<List<int>> result =
            [
                []
            ];

            foreach (int n in nums)
            {
                int currSize = result.Count;
                for (int i = 0; i < currSize; i++)
                {
                    List<int> subset = new(result[i]) { n };
                    result.Add(subset);
                }
            }

            return result.ToArray();
        }
    }
}
