namespace LeetCode.Medium
{
    internal class MinimumNumberOfOperationsToMakeArrayXOREqualToK
    {
        public static int MinOperations(int[] nums, int k)
        {
            int result = 0,
                initialXor = 0;

            foreach (int i in nums)
                initialXor ^= i;

            if (initialXor != k)
            {
                int targetSum = initialXor ^ k;
                while (targetSum > 0)
                {
                    result++;
                    targetSum &= (targetSum - 1);
                }
                return result;
            }
            else
                return result;
        }
    }
}
