namespace LeetCode.Medium
{
    internal class SortAnArray
    {
        public static int[] SortArray(int[] nums)
        {
            MergeSort(nums, 0, nums.Length - 1);
            return nums;

            void MergeSort(int[] array, int left, int right)
            {
                if (left < right)
                {
                    int mid = (left + right) / 2;
                    MergeSort(array, left, mid);
                    MergeSort(array, mid + 1, right);
                    Merge(array, left, mid, right);
                }
            }

            void Merge(int[] array, int left, int pivot, int right)
            {
                int leftSize = pivot - left + 1;
                int rightSize = right - pivot;
                int[] leftArray = new int[leftSize + 1];
                int[] rightArray = new int[rightSize + 1];

                for (int i = 0; i < leftSize; i++)
                    leftArray[i] = array[left + i];
                leftArray[leftSize] = int.MaxValue;

                for (int i = 0; i < rightSize; i++)
                    rightArray[i] = array[pivot + 1 + i];
                rightArray[rightSize] = int.MaxValue;

                int leftIndex = 0, rightIndex = 0;

                for (int i = left; i <= right; i++)
                    if (leftArray[leftIndex] <= rightArray[rightIndex])
                        array[i] = leftArray[leftIndex++];
                    else
                        array[i] = rightArray[rightIndex++];
            }
        }
    }
}
