namespace LeetCode.Easy
{
    internal class SumOfAllSubsetXORTotals
    {
        public static int SubsetXORSum(int[] nums)
        {
            int Recurse(int index, int result)
            {
                if (index == nums.Length)
                    return result;
                else
                    return Recurse(index + 1, result ^ nums[index]) + Recurse(index + 1, result);
            }
            return Recurse(0, 0);
        }
    }
}
