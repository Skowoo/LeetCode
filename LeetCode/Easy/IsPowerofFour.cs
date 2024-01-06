namespace LeetCode.Easy
{
    internal class IsPowerofFour
    {
        static bool IsPowerOfFour(int n)
        {
            if (n == 4 || n == 1)
                return true;
            else if (n % 4 != 0 || n < 0)
                return false;
            else if (n > 4)
                return IsPowerOfFour(n / 4);

            return false;
        }
    }
}
