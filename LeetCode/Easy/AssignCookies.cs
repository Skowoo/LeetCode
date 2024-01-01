namespace LeetCode.Easy
{
    internal class AssignCookies
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int ChildrenCounter = 0, Cookie = 0;

            while (Cookie < s.Length && ChildrenCounter < g.Length)
            {
                if (s[Cookie] >= g[ChildrenCounter])
                {
                    ChildrenCounter++;
                }
                Cookie++;
            }
            return ChildrenCounter;
        }
    }
}
