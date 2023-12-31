namespace LeetCode.Easy
{
    internal class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
                return nums.Length;

            int distinctNumberCounter = 1, lastNumber = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != lastNumber)
                {
                    lastNumber = nums[i];
                    nums[distinctNumberCounter] = nums[i];
                    distinctNumberCounter++;
                }
            }

            return distinctNumberCounter;
        }
    }
}
