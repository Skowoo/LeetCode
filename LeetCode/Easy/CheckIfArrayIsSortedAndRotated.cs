namespace LeetCode.Easy
{
    internal static class CheckIfArrayIsSortedAndRotated
    {
        public static bool Check(int[] nums)
        {
            bool wasRotated = false;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > nums[(i + 1) % nums.Length] && !wasRotated)
                    wasRotated = true;
                else if (nums[i] > nums[(i + 1) % nums.Length])
                    return false;

            return true;
        }
    }
}
