namespace LeetCode.Medium
{
    internal class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            int totalProduct = 1;
            bool zero = false;

            foreach (int i in nums)
                if (i == 0)
                    if (zero)
                        return new int[nums.Length];
                    else
                        zero = true;
                else
                    totalProduct *= i;

            for (int i = 0; i < nums.Length; i++)
                if (zero)
                    if (nums[i] == 0)
                        result[i] = totalProduct;
                    else
                        result[i] = 0;
                else
                    result[i] = totalProduct / nums[i];

            return result;
        }
    }
}
