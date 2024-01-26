namespace LeetCode.Easy
{
    internal class ANumberAfterADoubleReversal
    {
        public static bool IsSameAfterReversals(int num)
        {
            if (num < 10)
                return true;

            if (num % 10 != 0)
                return true;

            return false;
        }
    }
}
