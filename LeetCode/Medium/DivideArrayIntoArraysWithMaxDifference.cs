namespace LeetCode.Medium
{
    internal class DivideArrayIntoArraysWithMaxDifference
    {
        public static int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);

            int[][] resultList = new int[nums.Length / 3][];

            for (int i = 0; i < resultList.Length; i++)
                resultList[i] = new int[3];

            int currentFirstValue = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 3 == 0)
                    currentFirstValue = nums[i];

                if (currentFirstValue + k < nums[i])
                    return new int[0][];

                resultList[i / 3][i % 3] = nums[i];
            }

            return resultList;
        }
    }
}
