namespace LeetCode.Easy
{
    internal class ReverseString2
    {
        public static string ReverseStr(string s, int k)
        {
            var charArr = s.ToCharArray();

            for (int i = 0; i < s.Length; i += 2 * k)
            {
                int revLen = Math.Min(k, s.Length - i);
                Array.Reverse(charArr, i, revLen);
            }

            return new string(charArr);
        }
    }
}
