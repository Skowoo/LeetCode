using System.Text;

namespace LeetCode.Medium
{
    internal class ReverseSubstringsBetweenEachPairOfParentheses
    {
        public static string ReverseParentheses(string s)
        {
            char[] inputArray = s.ToCharArray();
            Stack<int> stack = new();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == '(')
                    stack.Push(i);
                else if (inputArray[i] == ')')
                {
                    int j = stack.Pop();
                    Array.Reverse(inputArray, j + 1, (i - j));
                }
            }

            StringBuilder result = new();
            foreach (char ch in inputArray)
                if (ch != '(' && ch != ')')
                    result.Append(ch);

            return result.ToString();
        }
    }
}

// Console.WriteLine(ReverseParentheses("(ed(et(oc))el)")); // leetcode