namespace LeetCode.Easy
{
    internal class MoveZeroes
    {
        public static void MoveZeroesFunc(int[] nums)
        {
            int slow = 0,
                fast = 0;

            while (fast < nums.Length)
            {
                if (nums[fast] != 0)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            for (int i = slow; i < nums.Length; i++)
                nums[i] = 0;
        }
    }
}
