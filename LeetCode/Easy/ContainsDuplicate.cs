namespace LeetCode.Easy
{
    internal class ContainsDuplicate
    {
        public static bool ContainsDuplicateFunc(int[] nums) => nums.Length != nums.Distinct().Count();
    }
}
