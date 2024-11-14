namespace LeetCode.Easy
{
    internal static class SumOfUniqueElements
    {
        public static int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> dic = [];
            foreach (int x in nums)
                if (dic.TryGetValue(x, out int result))
                    dic[x] = result + 1;
                else
                    dic[x] = 1;

            return dic.Where(x => x.Value == 1).Select(x => x.Key).Sum();
        }
    }
}
