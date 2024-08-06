namespace LeetCode.Medium
{
    internal class MinimumNumberOfPushesToTypeWordII
    {
        public static int MinimumPushes(string word)
        {
            Dictionary<char, int> letters = [];
            foreach (char c in word)
                if (letters.TryGetValue(c, out int value))
                    letters[c] = ++value;
                else
                    letters.Add(c, 1);

            int result = 0,
                index = 0;

            foreach (var letter in letters.OrderByDescending(x => x.Value))
            {
                result += letter.Value * (1 + (index / 8));
                index++;
            }

            return result;
        }
    }
}
