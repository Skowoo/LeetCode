namespace LeetCode.Medium
{
    internal class ContinuousSubarraySum
    {
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            int previousModulo = nums[0] % k,
                currentModulo;
            HashSet<int> moduloSet = [];
            for (int i = 1; i < nums.Length; i++)
            {
                currentModulo = (previousModulo + nums[i]) % k;

                if (currentModulo % k == 0 || moduloSet.Contains(currentModulo))
                    return true;

                moduloSet.Add(previousModulo);
                previousModulo = currentModulo;
            }
            return false;
        }
    }
}
