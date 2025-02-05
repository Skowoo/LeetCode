namespace LeetCode.Easy
{
    internal static class CheckIfOneStringSwapCanMakeStringsEqual
    {
        public static bool AreAlmostEqual(string s1, string s2)
        {
            string? discrepancy = null;
            bool haveHappened = false;
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] != s2[i])
                    if (discrepancy is null)
                        discrepancy = s1[i].ToString() + s2[i].ToString();
                    else if (discrepancy == s2[i].ToString() + s1[i].ToString() && !haveHappened)
                        haveHappened = true;
                    else
                        return false;

            return discrepancy is null || haveHappened && discrepancy is not null;
        }
    }
}
