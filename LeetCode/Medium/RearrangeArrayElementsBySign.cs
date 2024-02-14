namespace LeetCode.Medium
{
    internal class RearrangeArrayElementsBySign
    {
        public static int[] RearrangeArray(int[] nums)
        {
            var positive = nums.Where(x => x > 0).ToArray();
            var negative = nums.Where(x => x < 0).ToArray();

            List<int> result = new();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                result.Add(positive[i]);
                result.Add(negative[i]);
            }

            nums = result.ToArray();
            return nums;
        }
    }
}
