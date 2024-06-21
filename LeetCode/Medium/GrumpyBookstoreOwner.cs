namespace LeetCode.Medium
{
    internal class GrumpyBookstoreOwner
    {
        public static int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
        {
            int result = 0,
                currWindow = 0,
                maxWindow = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                if (grumpy[i] == 0)
                    result += customers[i];
                else
                    currWindow += customers[i];

                int windowStart = i - minutes;
                if (windowStart >= 0 && grumpy[windowStart] == 1)
                    currWindow -= customers[windowStart];

                maxWindow = Math.Max(maxWindow, currWindow);
            }

            return result + maxWindow;
        }
    }
}

// Console.WriteLine(MaxSatisfied([10, 1, 10, 1, 10, 1, 10], [1, 1, 1, 1, 1, 1, 1], 1));