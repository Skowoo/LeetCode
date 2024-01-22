namespace LeetCode.Easy
{
    internal class LongestPalindrome
    {
        public static int LongestPalindromeFunc(string s)
        {
            Dictionary<char, int> dictionary = new();
            int result = 0;
            bool singleLetterUsed = false;

            foreach (char c in s)
                if (dictionary.ContainsKey(c))
                    dictionary[c]++;
                else
                    dictionary.Add(c, 1);

            if (dictionary.Count == 1)
                return dictionary.Values.Sum();

            foreach (var pair in dictionary)
                if (pair.Value > 1 && pair.Value % 2 == 1)
                {
                    result += pair.Value - 1;
                    if (!singleLetterUsed)
                    {
                        singleLetterUsed = true;
                        result++;
                    }
                }
                else if (pair.Value > 1 && pair.Value % 2 == 0)
                {
                    result += pair.Value;
                }
                else if (!singleLetterUsed)
                {
                    singleLetterUsed = true;
                    result++;
                }

            return result;
        }
    }
}
