namespace LeetCode.Medium
{
    internal class TheNumberOfBeautifulSubsets
    {
        // Slow bad solution
        public static int BeautifulSubsets_Slow(int[] nums, int k)
        {
            List<List<int>> subsets = [[]];
            for (int i = 0; i < nums.Length; i++)
            {
                List<List<int>> temp = [];
                foreach (var set in subsets)
                    temp.Add(set.Select(x => x).ToList());

                foreach (var set in temp)
                {
                    if (IsBeauty(set, k, nums[i]))
                    {
                        List<int> sets = set.Select(x => x).ToList();
                        sets.Add(nums[i]);
                        subsets.Add(sets);
                    }
                }

                static bool IsBeauty(IEnumerable<int> nums, int k, int num)
                {
                    foreach (int n in nums)
                        if (Math.Abs(n - num) == k)
                            return false;

                    return true;
                }
            }
            return subsets.Count - 1;
        }
    }
}
