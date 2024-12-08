namespace LeetCode.Easy
{
    internal static class ThirdMaximumNumber
    {
        public static int ThirdMax(int[] nums)
        {
            var distinctNumbers = new HashSet<int>(nums).OrderByDescending(x => x);
            return distinctNumbers.Count() >= 3 ? distinctNumbers.Skip(2).First() : distinctNumbers.First();
        }
    }
}
