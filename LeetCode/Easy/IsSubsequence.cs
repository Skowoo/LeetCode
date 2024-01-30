namespace LeetCode.Easy
{
    internal class IsSubsequence
    {
        public static bool IsSubsequenceFunc(string s, string t)
        {
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
                return true;

            if (string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(t))
                return true;

            if (!string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
                return false;

            int result = 0;

            foreach (char c in t)
                if (s[result] == c)
                {
                    result++;
                    if (result == s.Length)
                        return true;
                }


            return result == s.Length;
        }
    }
}
