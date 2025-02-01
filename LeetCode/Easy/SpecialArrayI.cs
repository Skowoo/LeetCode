namespace LeetCode.Easy
{
    internal class SpecialArrayI
    {
        public static bool IsArraySpecial(int[] nums)
        {
            if (nums.Length < 2)
                return true;

            for (int i = 1; i < nums.Length; i++)
                if (nums[i] % 2 == nums[i - 1] % 2)
                    return false;

            return true;
        }
    }
}
