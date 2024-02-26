namespace LeetCode.Medium
{
    internal class SortColors
    {
        public static void SortColorsFunc(int[] nums) // Buddle sort
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