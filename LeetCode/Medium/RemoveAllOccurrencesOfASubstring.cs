namespace LeetCode.Medium
{
    internal static class RemoveAllOccurrencesOfASubstring
    {
        public static string RemoveOccurrences(string s, string part)
        {
            int index;
            if ((index = s.IndexOf(part)) != -1)
                return RemoveOccurrences(s.Remove(index, part.Length), part);
            else
                return s;
        }
    }
}
