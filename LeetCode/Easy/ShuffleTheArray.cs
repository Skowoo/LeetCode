namespace LeetCode.Easy
{
    internal static class ShuffleTheArray
    {
        public static int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];
            int firstPointer = 0,
                secondPointer = n;

            for (int i = 0; i < result.Length; i++)
                if (i % 2 == 0)
                    result[i] = nums[firstPointer++];
                else
                    result[i] = nums[secondPointer++];

            return result;
        }
    }
}
