namespace LeetCode.Medium
{
    internal static class ClosestPrimeNumbersInRange
    {
        public static int[] ClosestPrimes(int left, int right)
        {
            bool[] prime = new bool[right + 1];
            for (int i = 2; i <= right; i++)
                prime[i] = true;

            for (int i = 2; i * i <= right; i++)
                if (prime[i])
                    for (int j = i * i; j <= right; j += i)
                        prime[j] = false;

            List<int> targetRange = [];
            for (int i = Math.Max(left, 2); i <= right; i++)
                if (prime[i])
                    targetRange.Add(i);

            int minimalDifference = int.MaxValue;
            int first = -1, second = -1;

            for (int i = 0; i < targetRange.Count - 1; i++)
            {
                int diff = targetRange[i + 1] - targetRange[i];
                if (diff < minimalDifference)
                {
                    minimalDifference = diff;
                    first = targetRange[i];
                    second = targetRange[i + 1];

                    if (diff == 2)
                        break;
                }
            }

            return (first == second && second == -1) ? [-1, -1] : [first, second];
        }
    }
}
