namespace LeetCode.Medium
{
    internal class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
        }
    }
}

//var test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
//Rotate(test, 3);

//foreach (int i in test)
//    Console.Write(i + ", ");

//Console.WriteLine();
//test = new int[] { 1, 2 };
//Rotate(test, 3);

//foreach (int i in test)
//    Console.Write(i + ", ");