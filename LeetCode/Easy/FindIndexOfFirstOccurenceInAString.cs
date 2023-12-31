using System.Text.RegularExpressions;

namespace LeetCode.Easy
{
    internal class FindIndexOfFirstOccurenceInAString
    {
        public static int StrStr(string haystack, string needle)
        {
            Regex regex = new(needle);
            MatchCollection matches = regex.Matches(haystack);
            Match? result = matches.FirstOrDefault();
            if (result != null)
                return result.Index;
            else return -1;
        }
    }
}
