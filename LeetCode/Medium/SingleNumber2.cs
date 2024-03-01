namespace LeetCode.Medium
{
    internal class SingleNumber2
    {
        public static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            int candidate = nums[0];
            bool alreadySeen = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != candidate)
                {
                    if (!alreadySeen)
                        return candidate;

                    alreadySeen = false;
                }
                else
                {
                    alreadySeen = true;
                }

                candidate = nums[i];
            }

            return candidate;
        }
    }
}

// Console.WriteLine(SingleNumber(new int[] { 0,1,0,1,0,1,99 }));
// Console.WriteLine(SingleNumber(new int[] { 2, 2, 3, 2 }));