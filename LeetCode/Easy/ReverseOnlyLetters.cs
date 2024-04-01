using System.Text;

namespace LeetCode.Easy
{
    internal class ReverseOnlyLetters
    {
        public static string ReverseOnlyLetters__FUNC(string s)
        {
            List<char> letters = new();
            List<int> indexes = new();
            for (int i = 0; i < s.Length; i++)
                if (char.IsLetter(s[i]))
                {
                    indexes.Add(i);
                    letters.Add(s[i]);
                }

            letters.Reverse();
            StringBuilder sb = new(s);

            foreach (int i in indexes)
            {
                char target = letters.First();
                sb[i] = target;
                letters.Remove(target);
            }

            return sb.ToString();
        }
    }
}
