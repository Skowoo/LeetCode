namespace LeetCode.Medium
{
    internal class FindAllDuplicatesInAnArray
    {
        // Dictionary solution - bad :(
        public static IList<int> FindDuplicates(int[] nums)
        {
            Dictionary<int, int> numsCounter = new();
            foreach (int i in nums)
                if (numsCounter.ContainsKey(i))
                    numsCounter[i]++;
                else
                    numsCounter.Add(i, 1);

            return numsCounter.Where(x => x.Value > 1).Select(i => i.Key).ToList();
        }


        // Sorting - Better (yet still not good)
        public static IList<int> FindDuplicatesSorting(int[] nums)
        {
            Array.Sort(nums);
            List<int> result = new();
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] == nums[i - 1])
                    result.Add(nums[i]);
            return result;
        }

        // Two lists - Bad
        public static IList<int> FindDuplicatesTwoLists(int[] nums)
        {
            List<int> seen = new();
            List<int> result = new();

            foreach (int num in nums)
                if (seen.Contains(num))
                    result.Add(num);
                else
                    seen.Add(num);

            return result.Distinct().ToArray();
        }
    }
}
