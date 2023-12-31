namespace LeetCode.Easy
{
    internal class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new();

            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push('(');
                        break;
                    case ')':
                        if (stack.Count > 0)
                            if (stack.Peek() == '(')
                            {
                                stack.Pop();
                                break;
                            }

                        return false;
                    case '[':
                        stack.Push('[');
                        break;
                    case ']':
                        if (stack.Count > 0)
                            if (stack.Peek() == '[')
                            {
                                stack.Pop();
                                break;
                            }

                        return false;
                    case '{':
                        stack.Push('{');
                        break;
                    case '}':
                        if (stack.Count > 0)
                            if (stack.Peek() == '{')
                            {
                                stack.Pop();
                                break;
                            }

                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
