namespace LeetCode.Easy
{
    internal class RotateString
    {
        public static bool RotateStringFunc(string s, string goal)
        {
            if (s.Length != goal.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == goal[0])
                {
                    int sourceIndex = i;
                    for (int j = 0; j < goal.Length; j++)
                    {
                        if (s[sourceIndex] == goal[j])
                            sourceIndex = (j + i + 1) % s.Length;
                        else
                            break;

                        if (j == goal.Length - 1)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
