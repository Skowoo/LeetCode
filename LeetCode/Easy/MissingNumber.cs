namespace LeetCode.Easy
{
    internal class MissingNumber
    {
        public static int MissingNumberFunc(int[] nums) => nums.Length * (nums.Length + 1) / 2 - nums.Sum();
    }
}
