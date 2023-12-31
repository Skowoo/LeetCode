namespace LeetCode
{
    internal class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var combined = nums1.Concat(nums2).ToArray();
            Array.Sort(combined);

            int centerIndex = combined.Length / 2;

            if (combined.Length % 2 == 1)
                return combined[centerIndex];
            else
                return (double)(combined[centerIndex - 1] + combined[centerIndex]) / 2;
        }
    }
}
