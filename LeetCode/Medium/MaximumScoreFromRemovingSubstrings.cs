namespace LeetCode.Medium
{
    internal class MaximumScoreFromRemovingSubstrings
    {
        public static int MaximumGain(string s, int x, int y)
        {
            Stack<char> stack = new();
            char a = 'a',
                 b = 'b';
            int result = 0,
                point = Math.Max(x, y);

            if (y > x)
                (a, b) = (b, a);

            for (int i = 0; i < s.Length; i++)
                if (stack.Count > 0 && stack.Peek() == a && s[i] == b)
                {
                    stack.Pop();
                    result += point;
                }
                else
                    stack.Push(s[i]);

            point = Math.Min(x, y);

            Stack<char> newStack = new();
            while (stack.Count > 0)
            {
                char topLetter = stack.Pop();
                if (newStack.Count > 0 && topLetter == b && newStack.Peek() == a)
                {
                    newStack.Pop();
                    result += point;
                }
                else
                    newStack.Push(topLetter);
            }

            return result;
        }
    }
}
