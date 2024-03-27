namespace LeetCode.Medium
{
    internal class SubarrayProductLessThanK
    {
        // Brute force - O(n^2)
        public static int NumSubarrayProductLessThanK__Brute(int[] nums, int k)
        {
            long product;
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                product = nums[i];
                if (product < k)
                    result++;

                if (i == nums.Length - 1)
                    break;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    product *= nums[j];
                    if (product < k)
                        result++;
                    else
                        break;
                }
            }
            return result;
        }
    }
}
