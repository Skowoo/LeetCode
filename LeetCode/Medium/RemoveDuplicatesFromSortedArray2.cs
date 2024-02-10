namespace LeetCode.Medium
{
    internal class RemoveDuplicatesFromSortedArray2
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 3)
                return nums.Length;

            int endPoint = nums.Length;

            for (int i = 2; i < endPoint; i++)
                if (nums[i - 2] == nums[i] && nums[i - 1] == nums[i])
                {
                    endPoint--;

                    for (int j = i; j < nums.Length - 1; j++)
                        (nums[j + 1], nums[j]) = (nums[j], nums[j + 1]);

                    if (i != nums.Length - 1)
                        i--;
                }

            return endPoint;
        }
    }
}


//var test = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
//Console.WriteLine(RemoveDuplicates(test));

//foreach (int i in test)
//    Console.Write($"{i}, ");