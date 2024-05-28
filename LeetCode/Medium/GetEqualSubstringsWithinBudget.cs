namespace LeetCode.Medium
{
    internal class GetEqualSubstringsWithinBudget
    {
        public static int EqualSubstring(string s, string t, int maxCost)
        {
            int leftPointer = 0,
                currentCost = 0,
                maxLength = 0;

            for (int rightPointer = 0; rightPointer < s.Length; rightPointer++)
            {
                currentCost += Math.Abs(s[rightPointer] - t[rightPointer]);

                while (currentCost > maxCost)
                {
                    currentCost -= Math.Abs(s[leftPointer] - t[leftPointer]);
                    leftPointer++;
                }
                maxLength = Math.Max(maxLength, rightPointer - leftPointer + 1);
            }

            return maxLength;
        }
    }
}

// Console.WriteLine(EqualSubstring("abcd", "bcdf", 3));