namespace LeetCode.Medium
{
    internal class AppendCharactersToStringToMakeSubsequence
    {
        public static int AppendCharacters(string s, string t)
        {
            int pointerT = 0,
                pointerS = 0;

            while (pointerS < s.Length && pointerT < t.Length)
            {
                if (t[pointerT] == s[pointerS])
                    pointerT++;
                pointerS++;
            }

            return t.Length - pointerT;
        }
    }
}
