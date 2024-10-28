namespace LeetCode.Medium
{
    internal class LongestSquareStreakInAnArray
    {
        public static int LongestSquareStreak(int[] nums)
        {
            HashSet<int> set = new(nums);
            int max = -1;

            foreach (int num in set)
                if (set.Contains((int)Math.Pow(num, 2)))
                {
                    int counter = 2,
                        squared = (int)Math.Pow(num, 2);

                    while (true)
                    {
                        if (set.Contains((int)Math.Pow(squared, 2)))
                        {
                            squared = (int)Math.Pow(squared, 2);
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    max = Math.Max(max, counter);
                }

            return max;
        }
    }
}

//Console.WriteLine(LongestSquareStreak([4, 3, 6, 16, 8, 2]));
//Console.WriteLine(LongestSquareStreak([2, 3, 5, 6, 7]));
//Console.WriteLine(LongestSquareStreak([2, 49, 3, 5, 7, 2401]));