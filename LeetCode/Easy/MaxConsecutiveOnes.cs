namespace LeetCode.Easy
{
    internal class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0,
                curr = 0;

            foreach (int x in nums)
                if (x == 1)
                {
                    curr++;
                    max = Math.Max(max, curr);
                }
                else
                    curr = 0;

            return max;
        }
    }
}
