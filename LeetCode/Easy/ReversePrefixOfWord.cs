namespace LeetCode.Easy
{
    internal class ReversePrefixOfWord
    {
        public static string ReversePrefix(string word, char ch)
        {
            var arr = word.ToCharArray();
            int index = Array.IndexOf(arr, ch);
            var reversed = arr.Take(index + 1).Reverse().ToArray();
            string result = new(reversed);
            result += new string(arr.Skip(index + 1).ToArray());
            return result;
        }
    }
}
