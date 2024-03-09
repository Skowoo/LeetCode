namespace LeetCode.Easy
{
    internal class MinimumCommonValue
    {
        // Two Pointer solution
        public static int GetCommon(int[] nums1, int[] nums2)
        {
            int firstPointer = 0, secondPointer = 0;
            while (firstPointer < nums1.Length && secondPointer < nums2.Length)
            {
                if (nums1[firstPointer] == nums2[secondPointer])
                    return nums1[firstPointer];

                if (nums1[firstPointer] < nums2[secondPointer])
                    firstPointer++;
                else
                    secondPointer++;
            }

            return -1;
        }

        // Slow LINQ solution
        public static int GetCommonLINQ(int[] nums1, int[] nums2)
        {
            var resultSet = nums1.Intersect(nums2);
            return resultSet.Any() ? resultSet.Min() : -1;
        }
    }
}
