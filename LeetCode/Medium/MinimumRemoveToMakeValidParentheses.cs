using System.Text;

namespace LeetCode.Medium
{
    internal class MinimumRemoveToMakeValidParentheses
    {
        public static string MinRemoveToMakeValid(string s)
        {
            Stack<int> openingsStack = new();
            List<int> notClosedIndexes = new();

            for (int i = 0; i < s.Length; i++)
                if (s[i] == '(')
                    openingsStack.Push(i);
                else if (s[i] == ')')
                    if (!openingsStack.TryPop(out var _))
                        notClosedIndexes.Add(i);

            StringBuilder result = new();

            foreach (int item in openingsStack)
                notClosedIndexes.Add(item);

            for (int i = 0; i < s.Length; i++)
                if (!notClosedIndexes.Contains(i))
                    result.Append(s[i]);

            return result.ToString();
        }
    }
}
