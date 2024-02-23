namespace LeetCode.Medium
{
    internal class IncreasingTripletSubsequence
    {
        public static bool IncreasingTriplet(int[] nums)
        {
            int first = nums[0];
            int second = int.MaxValue;

            foreach (int x in nums)
                if (first < second && second < x)
                    return true;
                else
                    if (first < x && second > x)
                    second = x;
                else if (first > x)
                    first = x;

            return false;
        }
    }
}
