namespace LeetCode.Easy
{
    internal class NumberComplement // + 1009 Complement of Base 10 Integer
    {
        public static int FindComplement(int num)
        {
            int mask = 1;
            while (mask < num)
                mask = (mask << 1) | 1;
            return num ^ mask;
        }
    }
}
