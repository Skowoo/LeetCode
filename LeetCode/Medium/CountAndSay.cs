using System.Text;

namespace LeetCode.Medium
{
    internal static class CountAndSay
    {
        public static string CountAndSay_Func(int n)
        {
            if (n == 1)
                return "1";

            StringBuilder result = new("1");

            for (int i = 1; i < n; i++)
            {
                StringBuilder temp = new();
                int count = 1;

                for (int j = 1; j < result.Length; j++)
                {
                    if (result[j] == result[j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        temp.Append(count.ToString() + result[j - 1]);
                        count = 1;
                    }
                }

                temp.Append(count.ToString() + result[^1]);
                result = temp;
            }

            return result.ToString();
        }
    }
}
