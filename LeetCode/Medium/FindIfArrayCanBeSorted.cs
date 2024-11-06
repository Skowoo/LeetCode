namespace LeetCode.Medium
{
    internal class FindIfArrayCanBeSorted
    {
        public static bool CanSortArray(int[] nums)
        {
            bool swapMade = true;
            while (swapMade)
            {
                swapMade = false;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < nums[i - 1])
                    {
                        if (CountBits(nums[i]) != CountBits(nums[i - 1]))
                            return false;

                        (nums[i], nums[i - 1]) = (nums[i - 1], nums[i]);
                        swapMade = true;
                    }
                }
            }

            return true;

            static int CountBits(int n)
            {
                int counter = 0;
                while (n > 0)
                {
                    counter += n & 1;
                    n >>= 1;
                }
                return counter;
            }
        }
    }
}
