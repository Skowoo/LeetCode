﻿namespace LeetCode.Easy
{
    internal class PowerOfTwo
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n < 1)
                return false;

            while (n > 1)
            {
                if (n % 2 != 0)
                    return false;

                n /= 2;
            }

            return true;
        }
    }
}
