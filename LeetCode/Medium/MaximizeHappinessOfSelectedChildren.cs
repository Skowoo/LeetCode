namespace LeetCode.Medium
{
    internal class MaximizeHappinessOfSelectedChildren
    {
        public static long MaximumHappinessSum(int[] happiness, int k)
        {
            long result = 0;
            int counter = 0;
            Array.Sort(happiness);
            for (int i = happiness.Length - 1; i >= happiness.Length - k; i--)
            {
                result += happiness[i] - counter < 0 ? 0 : happiness[i] - counter;
                counter++;
            }
            return result;
        }
    }
}
