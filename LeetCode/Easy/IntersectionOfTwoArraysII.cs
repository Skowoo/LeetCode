namespace LeetCode.Easy
{
    internal class IntersectionOfTwoArraysII
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = [];
            Dictionary<int, int> dic1 = [],
                dic2 = [];

            foreach (int num in nums1)
                if (dic1.TryGetValue(num, out int value))
                    dic1[num] = ++value;
                else
                    dic1.Add(num, 1);

            foreach (int num in nums2)
                if (dic2.TryGetValue(num, out int value))
                    dic2[num] = ++value;
                else
                    dic2.Add(num, 1);

            foreach (int key in dic1.Keys)
                if (dic2.TryGetValue(key, out int value))
                    for (int i = 0; i < Math.Min(dic1[key], value); i++)
                        result.Add(key);

            return [.. result];
        }

        public static int[] Intersect_Bad(int[] nums1, int[] nums2)
        {
            List<int> result = [];
            foreach (int num in nums1.Distinct())
                if (nums1.Contains(num) && nums2.Contains(num))
                    for (int i = 0; i < Math.Min(nums1.Where(x => x == num).Count(), nums2.Where(x => x == num).Count()); i++)
                        result.Add(num);

            return [.. result];
        }
    }
}
