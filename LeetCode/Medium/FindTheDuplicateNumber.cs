namespace LeetCode.Medium
{
    internal class FindTheDuplicateNumber
    {
        public static int FindDuplicate(int[] nums)
        {
            int tortoise = nums[0], hare = nums[0];
            while (true)
            {
                tortoise = nums[tortoise];
                hare = nums[nums[hare]];
                if (tortoise == hare)
                    break;
            }

            int firstPointer = nums[0];
            int secondPointer = tortoise;

            while (firstPointer != secondPointer)
            {
                firstPointer = nums[firstPointer];
                secondPointer = nums[secondPointer];
            }

            return firstPointer;
        }

        public static int FindDuplicateBrutal(int[] nums)
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
