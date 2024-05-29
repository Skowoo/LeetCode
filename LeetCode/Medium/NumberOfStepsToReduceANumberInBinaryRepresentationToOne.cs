using System.Text;

namespace LeetCode.Medium
{
    internal class NumberOfStepsToReduceANumberInBinaryRepresentationToOne
    {
        public static int NumSteps(string s)
        {
            StringBuilder sb = new(s);
            int result = 0;

            while (sb.Length > 1)
            {
                if (sb[^1] == '0')
                    sb.Length--;
                else
                {
                    int x = sb.Length - 1;
                    while (x >= 0 && sb[x] == '1')
                    {
                        sb[x] = '0';
                        x--;
                    }

                    if (x >= 0)
                        sb[x] = '1';
                    else
                        sb.Insert(0, '1');
                }
                result++;
            }

            return result;
        }
    }
}
