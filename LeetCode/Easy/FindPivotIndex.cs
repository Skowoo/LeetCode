namespace LeetCode.Easy
{
    internal static class FindPivotIndex
    {
        public static int PivotIndex(int[] nums)
        {
            int totalSum = nums.Sum(),
                currSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                totalSum -= nums[i];

                if (currSum == totalSum)
                    return i;

                currSum += nums[i];

                if (currSum > totalSum)
                    break;
            }

            return -1;
        }
    }
}
