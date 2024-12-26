namespace LeetCode.Easy
{
    internal static class Sqrt_x_
    {
        public static int MySqrt(int x)
        {
            if (x < 2)
                return x;

            double cdt = 1;
            while (true)
            {
                if ((cdt * cdt) <= x && ((cdt + 1) * (cdt + 1)) > x)
                    return (int)cdt;

                cdt++;
            }
        }
    }
}
