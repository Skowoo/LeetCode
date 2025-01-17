namespace LeetCode.Easy
{
    internal static class ValidMountainArray
    {
        public static bool ValidMountainArray_Func(int[] arr)
        {
            int index = 0;

            while (index + 1 < arr.Length && arr[index] < arr[index + 1])
                index++;

            if (index == 0 || index == arr.Length - 1)
                return false;

            while (index + 1 < arr.Length && arr[index] > arr[index + 1])
                index++;

            return index == arr.Length - 1;
        }
    }
}
