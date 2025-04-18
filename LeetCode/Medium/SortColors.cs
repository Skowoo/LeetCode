namespace LeetCode.Medium
{
    internal static class SortColors
    {
        public static void SortColors_CountingSort(int[] nums)
        {
            int[] counter = new int[3];
            foreach (int i in nums)
                counter[i]++;

            int counterIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (counter[counterIndex] == 0)
                {
                    counterIndex++;
                    i--;
                }
                else
                {
                    nums[i] = counterIndex;
                    counter[counterIndex]--;
                }
            }
        }

        public static void SortColors_BubbleSort(int[] nums)
        {
            bool swapMade = true;
            while (swapMade)
            {
                swapMade = false;
                for (int i = 1; i < nums.Length; i++)
                    if (nums[i] < nums[i - 1])
                    {
                        int temp = nums[i];
                        nums[i] = nums[i - 1];
                        nums[i - 1] = temp;
                        swapMade = true;
                    }
            }
        }
    }
}


//int[] test1 = new int[] { 2, 0, 2, 1, 1, 0 };

//SortColors(test1);

//foreach (int test2 in test1)
//    Console.Write(test2 + ", ");