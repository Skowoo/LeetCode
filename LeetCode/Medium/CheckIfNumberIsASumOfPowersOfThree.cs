namespace LeetCode.Medium
{
    internal static class CheckIfNumberIsASumOfPowersOfThree
    {
        public static bool CheckPowersOfThree(int n)
        {
            while (n > 1)
            {
                int rest = n % 3;
                if (rest == 2)
                    return false;
                else
                    n /= 3;
            }
            return true;
        }
    }
}
