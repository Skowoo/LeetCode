namespace LeetCode.Medium
{
    // Problems 560 and 930 - same solution different variable names.
    internal class SubarraySumEqualsK_BinarySubarraysWithSum
    {


        public static int O_n_Square(int[] nums, int k)
        {
            int sum, counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (sum == k)
                        counter++;
                }
            }

            return counter;
        }
    }
}

// int[] test = { 1, 0, 1, 0, 1 };
// Console.WriteLine(NumSubarraysWithSum(test, 2) + " / 4");
// int[] test2 = { 0, 0, 0, 0, 0 };
// Console.WriteLine(NumSubarraysWithSum(test2, 0) + " / 15");