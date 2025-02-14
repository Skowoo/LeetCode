namespace LeetCode.Easy
{
    internal static class MaximumNumberOfBalloons
    {
        public static int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> letters = new()
            {
                { 'b', 0 },
                { 'a', 0 },
                { 'l', 0 },
                { 'o', 0 },
                { 'n', 0 }
            };

            foreach (char letter in text)
                if (letters.TryGetValue(letter, out int value))
                    letters[letter] = ++value;

            letters['o'] /= 2;
            letters['l'] /= 2;

            int result = int.MaxValue;
            foreach (var letter in letters)
                result = Math.Min(result, letter.Value);

            return result;
        }
    }
}
