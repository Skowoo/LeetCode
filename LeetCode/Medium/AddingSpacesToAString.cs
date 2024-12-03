using System.Text;

namespace LeetCode.Medium
{
    internal static class AddingSpacesToAString
    {
        public static string AddSpaces(string s, int[] spaces)
        {
            StringBuilder sb = new(s);
            for (int i = 0; i < spaces.Length; i++)
                sb.Insert(i + spaces[i], ' ');

            return sb.ToString();
        }
    }
}
