namespace LeetCode.Easy
{
    internal static class RichestCustomerWealth
    {
        public static int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            foreach (var account in accounts)
            {
                int curValue = 0;
                foreach (var item in account)
                    curValue += item;

                max = Math.Max(max, curValue);
            }
            return max;
        }

        public static int MaximumWealth_Slow(int[][] accounts)
            => accounts.Select(a => a.Sum()).Max();
    }
}
