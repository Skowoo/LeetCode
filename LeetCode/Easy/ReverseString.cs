namespace LeetCode.Easy
{
    internal class ReverseString
    {
        public static void ReverseString_Func(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
                (s[i], s[s.Length - i - 1]) = (s[i], s[s.Length - i - 1]);
        }
    }
}
