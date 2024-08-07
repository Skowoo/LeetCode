namespace LeetCode.Easy
{
    internal class PassThePillow
    {
        public static int PassThePillow_Func(int n, int time)
        {
            return (time / (n - 1)) % 2 != 1 ? (time % (n - 1)) + 1 : n - (time % (n - 1));
        }
    }
}
