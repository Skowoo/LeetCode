namespace LeetCode.Medium
{
    internal class CompareVersionNumbers
    {
        public static int CompareVersion(string version1, string version2)
        {
            bool inversed;
            var q1 = version1.Split('.').Select(x => long.Parse(x));
            var q2 = version2.Split('.').Select(x => long.Parse(x));
            long[] longer, shorter;
            if (q1.Count() >= q2.Count())
            {
                longer = q1.ToArray();
                shorter = q2.ToArray();
                inversed = false;
            }
            else
            {
                longer = q2.ToArray();
                shorter = q1.ToArray();
                inversed = true;
            }

            for (int i = 0; i < longer.Length; i++)
                if (i < shorter.Length)
                {
                    if (longer[i] > shorter[i])
                        return inversed ? -1 : 1;
                    else if (longer[i] < shorter[i])
                        return inversed ? 1 : -1;
                }
                else
                    if (longer[i] > 0)
                    return inversed ? -1 : 1;

            return 0;
        }
    }
}

//Console.WriteLine(CompareVersion("1.01", "1.001"));
//Console.WriteLine(CompareVersion("1.0", "1.0.0"));
//Console.WriteLine(CompareVersion("0.1", "1.1"));
//Console.WriteLine(CompareVersion("1.1", "0.1"));
