namespace LeetCode.Medium
{
    internal class JumpGame
    {
        public static bool CanJump(int[] nums)
        {
            int lastAccesibleIndex = nums.Length - 1;

            for (int i = lastAccesibleIndex; i >= 0; i--)
                if (i + nums[i] >= lastAccesibleIndex)
                    lastAccesibleIndex = i;

            return lastAccesibleIndex == 0;
        }
    }
}
