namespace LeetCode.Easy
{
    internal static class FirstBadVersion
    {
        public static int FirstBadVersion_Func(int n)
        {
            int max = n,
                min = 1,
                result = 0;

            while (min <= max)
            {
                int mid = min + (max - min) / 2;
                if (IsBadVersion(mid))
                {
                    result = mid;
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return result;
        }

        /// <summary>
        /// Mockup class
        /// </summary>
        private static bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
        }
    }
}
