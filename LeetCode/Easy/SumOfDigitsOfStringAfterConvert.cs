using System.Text;

namespace LeetCode.Easy
{
    internal class SumOfDigitsOfStringAfterConvert
    {
        public static int GetLucky(string s, int k)
        {
            StringBuilder baseSb = new();
            foreach (char c in s)
                baseSb.Append(c - 96);

            string numberString = baseSb.ToString();
            int result = 0;

            for (int i = 0; i < k; i++)
            {
                result = numberString.Sum(c => c - 48);
                numberString = result.ToString();
            }

            return result;
        }
    }
}
