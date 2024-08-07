namespace LeetCode.Easy
{
    internal class ThreeConsecutiveOdds
    {
        // O(n) time complexity, O(1) space complexity
        public static bool ThreeConsecutiveOdds_Func(int[] arr)
        {
            int count = 0;
            foreach (var num in arr)
            {
                if (num % 2 == 1)
                    count++;
                else
                    count = 0;

                if (count == 3)
                    return true;
            }
            return false;
        }
    }
}
