namespace LeetCode.Easy
{
    internal static class BinaryPrefixDivisibleBy5
    {
        public static IList<bool> PrefixesDivBy5(int[] nums)
        {
            bool[] result = new bool[nums.Length];
            int currNum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currNum = (currNum * 2 + nums[i]) % 5;
                result[i] = currNum == 0;
            }

            return result;
        }
    }
}
