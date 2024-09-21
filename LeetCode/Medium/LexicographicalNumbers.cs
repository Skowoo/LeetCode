namespace LeetCode.Medium
{
    internal class LexicographicalNumbers
    {
        public static IList<int> LexicalOrder(int n)
        {
            List<int> result = Enumerable.Range(1, n).ToList();
            return result.OrderBy(x => x.ToString()).Select(x => (int)x).ToList();
        }
    }
}
