namespace LeetCode.Medium
{
    internal class ReverseWordsInAString
    {

        public static string ReverseWords(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(' ', words);
        }
    }
}
