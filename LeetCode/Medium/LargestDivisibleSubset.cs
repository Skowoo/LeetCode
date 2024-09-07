namespace LeetCode.Medium
{
    internal class LargestDivisibleSubset
    {
        public static IList<int> LargestDivisibleSubset_Func(int[] nums)
        {
            Array.Sort(nums);

            (List<int>, int)[] memo = new (List<int>, int)[nums.Length];
            memo[0] = ([nums[0]], 1);
            int maxIndex = 0;

            for (int i = 1; i < nums.Length; ++i)
            {
                int maxValue = 1;
                memo[i] = (new List<int>() { nums[i] }, maxValue);
                for (int j = 0; j < i; ++j)
                    if (nums[i] % nums[j] == 0 && memo[j].Item2 + 1 > maxValue)
                    {
                        maxValue = memo[j].Item2 + 1;
                        var tempList = new List<int>(memo[j].Item1) { nums[i] };

                        if (tempList.Count > memo[maxIndex].Item1.Count)
                            maxIndex = i;

                        memo[i] = (tempList, maxValue);
                    }
            }

            return memo[maxIndex].Item1;
        }
    }
}
