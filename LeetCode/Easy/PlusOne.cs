namespace LeetCode.Easy
{
    internal class PlusOne
    {
        public static int[] PlusOneFunc(int[] digits)
        {
            bool remainder = false;

            for (int i = 1; i < digits.Length + 1; i++)
                if (digits[^i] != 9 && i == 1)
                {
                    digits[^i]++;
                    return digits;
                }
                else if (digits[^i] == 9)
                {
                    digits[^i] = 0;
                    remainder = true;
                }
                else if (remainder)
                {
                    digits[^i]++;
                    return digits;
                }

            if (remainder)
                return new int[] { 1 }.Concat(digits).ToArray();
            else
                return digits;
        }
    }
}
