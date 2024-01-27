namespace LeetCode.Easy
{
    internal class MonotonicArray
    {
        public static bool IsMonotonic(int[] nums)
        {
            bool result = true;

            if (nums.Length < 2)
                return result;

            bool rising = false;
            bool decreasing = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (!decreasing && !rising)
                {
                    if (nums[i] < nums[i - 1])
                        decreasing = true;
                    if (nums[i] > nums[i - 1])
                        rising = true;
                }
                else
                {
                    if (rising)
                    {
                        if (nums[i] < nums[i - 1])
                            return false;
                    }
                    else if (nums[i] > nums[i - 1])
                        return false;
                }
            }

            return result;
        }
    }
}
