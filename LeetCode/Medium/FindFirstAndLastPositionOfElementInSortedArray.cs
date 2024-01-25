namespace LeetCode.Medium
{
    internal class FindFirstAndLastPositionOfElementInSortedArray
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            int[] result = { -1, -1 };
            bool firstFound = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target && !firstFound)
                {
                    result[0] = i;
                    firstFound = true;
                    continue;
                }
                if (nums[i] != target && firstFound)
                {
                    result[1] = i - 1;
                    return result;
                }
            }

            if (firstFound)
                result[1] = nums.Length - 1;

            return result;
        }
    }
}
