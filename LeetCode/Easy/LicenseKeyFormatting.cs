using System.Text;

namespace LeetCode.Easy
{
    internal static class LicenseKeyFormatting
    {
        public static string LicenseKeyFormattingFunc(string s, int k)
        {
            var clean = s.Replace("-", "").ToUpper();
            StringBuilder sb = new();
            int counter = 0;
            for (int i = clean.Length - 1; i >= 0; i--)
            {

                counter++;

                sb.Insert(0, clean[i]);

                if (counter == k && i != 0)
                {
                    counter = 0;
                    sb.Insert(0, '-');
                }
            }

            return sb.ToString();
        }
    }
}
