namespace LeetCode.Easy
{
    internal class MaximumOddBinaryNumber
    {
        public static string MaximumOddBinaryNumberFunc(string s)
        {
            var array = s.ToCharArray();
            int onesCount = array.Where(x => x == '1').Count();
            int zerosCount = array.Length - onesCount;
            if (onesCount == 1)
                return "1";

            string result = string.Empty;
            for (int i = 0; i < onesCount - 1; i++)
                result += '1';

            for (int i = 0; i < zerosCount; i++)
                result += '0';

            return result + '1';
        }
    }
}
