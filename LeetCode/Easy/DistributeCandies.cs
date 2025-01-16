namespace LeetCode.Easy
{
    internal static class DistributeCandies
    {
        public static int DistributeCandies_Func(int[] candyType)
        {
            var set = new HashSet<int>(candyType);
            return Math.Min(set.Count, candyType.Length / 2);
        }
    }
}
