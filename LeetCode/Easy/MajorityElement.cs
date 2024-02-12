namespace LeetCode.Easy
{
    internal class MajorityElement
    {
        public static int MajorityElementFunc(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            Dictionary<int, int> numberCounter = new();

            foreach (int num in nums)
            {
                if (numberCounter.ContainsKey(num))
                {
                    numberCounter[num]++;
                    if (numberCounter[num] > nums.Length / 2)
                        return num;
                }
                else
                {
                    numberCounter.Add(num, 1);
                }
            }

            return numberCounter.OrderByDescending(x => x.Value).First().Key;
        }
    }
}
