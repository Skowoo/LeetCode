namespace LeetCode.Medium
{
    internal class MinimumNumberOfDaysToMakeMBouquets
    {

        public static int MinDays(int[] bloomDay, int m, int k)
        {
            if ((long)(m * k) > bloomDay.Length)
                return -1;

            int result = -1,
                start = 0,
                end = 0;

            foreach (int val in bloomDay)
                end = Math.Max(end, val);

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (Count(mid) >= m)
                {
                    result = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return result;

            int Count(int value)
            {
                int result = 0,
                    flowers = 0;

                foreach (var day in bloomDay)
                    if (day <= value)
                    {
                        flowers++;
                        if (flowers == k)
                        {
                            result++;
                            flowers = 0;
                        }
                    }
                    else
                    {
                        flowers = 0;
                    }

                return result;
            }
        }
    }
}
