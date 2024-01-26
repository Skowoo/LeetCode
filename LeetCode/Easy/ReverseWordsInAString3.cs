namespace LeetCode.Easy
{
    internal class ReverseWordsInAString3
    {
        public static string ReverseWords(string s)
        {
            string[] words = s.Split(' ').ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                var tempArray = words[i].ToCharArray();
                Array.Reverse(tempArray);
                words[i] = new string(tempArray);
            }

            return string.Join(" ", words);
        }
    }
}
