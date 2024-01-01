namespace LeetCode.Hard
{
    internal class FirstMissingPositive
    {
        public static int FirstMissingPositive3(int[] nums) // 2403 ms, 57,84 MB
        {
            List<int> ints = new(nums);

            var solution = ints.Where(x => x > 1).ToList();
            solution.Sort();

            for (int i = 1; i < nums.Length + 1; i++)
                if (!solution.Contains(i))
                    return i;

            return solution.Count + 1;
        }

        public static int FirstMissingPositive2(int[] nums) // 2680 ms, 56.07 MB
        {
            List<int> ints = new(nums);

            if (ints.Max() < 1)
                return 0;

            var solution = ints.Where(x => x > 1).ToList();
            solution.Sort();

            for (int i = 1; i < nums.Length + 1; i++)
                if (!solution.Contains(i))
                    return i;

            return solution.Count + 1;
        }

        public static int FirstMissingPositive1(int[] nums) // 2352 ms, 54.07 MB
        {
            for (int i = 1; i < nums.Length + 1; i++)
                if (!nums.Contains(i))
                    return i;
            return nums.Length + 1;
        }
    }
}
