namespace LeetCode.Medium
{
    internal class SubarraySumsDivisibleByK
    {
        public static int SubarraysDivByK(int[] nums, int k)
        {
            Dictionary<int, int> remainders = [];
            remainders.Add(0, 1);
            int prevSum = 0,
                result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                prevSum += nums[i];
                int remainder = prevSum % k;

                if (remainder < 0)
                    remainder += k;

                if (remainders.TryGetValue(remainder, out int frequency))
                {
                    result += frequency;
                    remainders[remainder] = ++frequency;
                }
                else
                    remainders.Add(remainder, 1);
            }
            return result;
        }
    }
}
