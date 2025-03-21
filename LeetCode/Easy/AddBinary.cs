using System.Text;

namespace LeetCode.Easy
{
    internal static class AddBinary
    {
        public static string AddBinary_Experimental(string a, string b)
        {
            int remainder = 0;
            int aIndex = a.Length - 1;
            int bIndex = b.Length - 1;
            StringBuilder result = new();
            while (aIndex >= 0 || bIndex >= 0 || remainder == 1)
            {
                if (aIndex >= 0) remainder += a[aIndex--] - '0';
                if (bIndex >= 0) remainder += b[bIndex--] - '0';
                result.Append(remainder % 2);
                remainder /= 2;
            }
            var resultArray = result.ToString().ToCharArray();
            return new string([.. resultArray.Reverse()]);
        }
    }
}
