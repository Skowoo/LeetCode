namespace LeetCode.Easy
{
    internal class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
                return 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] >= target)
                    return i;

            return nums.Length;
        }
    }
}
