namespace LeetCode.Medium
{
    internal class MinimizeMaximumPairSumInArray
    {
        public static int MinPairSum(int[] nums)
        {
            int result = 0;

            var orderedArray = nums.OrderBy(x => x).ToArray();

            for (int i = 0; i < orderedArray.Length / 2; i++)
                if (orderedArray[i] + orderedArray[orderedArray.Length - i - 1] > result)
                    result = orderedArray[i] + orderedArray[orderedArray.Length - i - 1];

            return result;
        }
    }
}
