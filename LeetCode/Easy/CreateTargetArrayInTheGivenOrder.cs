namespace LeetCode.Easy
{
    internal static class CreateTargetArrayInTheGivenOrder
    {
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; j > index[i]; j--)
                    result[j] = result[j - 1];

                result[index[i]] = nums[i];
            }

            return result;
        }
    }
}
