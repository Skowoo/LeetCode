namespace LeetCode.Easy
{
    internal static class FindAllNumbersDisappearedInAnArray
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            int[] re = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                re[i] = i + 1;

            return re.Except(nums).ToList();
        }
    }
}
