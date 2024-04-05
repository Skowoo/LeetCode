namespace LeetCode.Easy
{
    internal class MakeTheStringGreat
    {
        public static string MakeGood(string s)
        {
            List<char> chars = new(s);
            bool altered = true;
            while (altered)
            {
                altered = false;
                for (int i = 1; i < chars.Count; i++)
                    if (chars[i] == (chars[i - 1] - 32) || chars[i - 1] == (chars[i] - 32))
                    {
                        chars.RemoveAt(i);
                        chars.RemoveAt(i - 1);
                        altered = true;
                        break;
                    }
            }
            return new string(chars.ToArray());
        }
    }
}
