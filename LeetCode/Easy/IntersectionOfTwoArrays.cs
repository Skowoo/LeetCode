namespace LeetCode.Easy
{
    internal class IntersectionOfTwoArrays
    {
        // Best solution
        public static int[] Intersection(int[] nums1, int[] nums2) => GetIntersection(nums1, nums2).ToArray();

        static IEnumerable<int> GetIntersection(int[] arr1, int[] arr2)
        {
            HashSet<int> result = new(arr1); // HashSet from base array for fast access and elimination of duplicates
            foreach (int i in arr2)          // Iterate through second array
                if (result.Remove(i))        // Check if you can remove FROM base array each number of second array
                    yield return i;          // If true it means that in base array there is current number from second array
        }                                    // It means that you can add it to result list OR yield return it to avoid creation of new collection (memory savings)

        // Simplest solution
        public static int[] Intersection_Simple(int[] nums1, int[] nums2)
        {
            int[] shorter, longer;

            if (nums1.Length >= nums2.Length)
            {
                shorter = nums2;
                longer = nums1;
            }
            else
            {
                shorter = nums1;
                longer = nums2;
            }

            List<int> commonNumbers = new();

            foreach (int num in shorter)
                if (longer.Contains(num))
                    if (!commonNumbers.Contains(num))
                        commonNumbers.Add(num);

            return commonNumbers.ToArray();
        }

        // LINQ solution
        public static int[] Intersection_LINQ(int[] nums1, int[] nums2) => nums1.Intersect(nums2).ToArray();
    }
}
