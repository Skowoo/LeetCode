namespace LeetCode.Medium
{
    internal class ContiguousArray
    {
        public static int FindMaxLength(int[] nums)
        {
            if (nums.Length < 2)
                return 0;

            int maxLength = 0, sum = nums[0] == 1 ? 1 : -1;

            Dictionary<int, int> dictionary = new()
            {
                { 0, -1 },
                { sum, 0 }
            };

            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i] == 1 ? nums[i] : -1;

                if (dictionary.ContainsKey(sum))
                    maxLength = Math.Max(maxLength, i - dictionary[sum]);
                else
                    dictionary.Add(sum, i);
            }

            return maxLength;
        }
    }
}
