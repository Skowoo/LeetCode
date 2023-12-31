namespace LeetCode.Easy
{
    internal class RemoveElement
    {
        public static int RemoveElementFunc(int[] nums, int val)
        {
            int noValCounter = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != val)
                    nums[noValCounter++] = nums[i];

            return noValCounter;
        }
    }
}
