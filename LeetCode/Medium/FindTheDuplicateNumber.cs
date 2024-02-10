namespace LeetCode.Medium
{
    internal class FindTheDuplicateNumber
    {
        public static int FindDuplicate(int[] nums)
        {
            List<int> ints = new();
            foreach (int i in nums)
                if (ints.Contains(i))
                    return i;
                else
                    ints.Add(i);

            return -1;
        }
    }
}
