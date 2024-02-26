namespace LeetCode.Medium
{
    internal class LetterCombinationsOfAPhoneNumber
    {

        public static IList<string> LetterCombinations(string digits)
        {
            List<string> result = new();
            Dictionary<char, List<string>> keyLetters = new()
            {
                { '2', new List<string>() { "a", "b", "c" } },
                { '3', new List<string>() { "d", "e", "f" } },
                { '4', new List<string>() { "g", "h", "i" } },
                { '5', new List<string>() { "j", "k", "l" } },
                { '6', new List<string>() { "m", "n", "o" } },
                { '7', new List<string>() { "p", "q", "r", "s" } },
                { '8', new List<string>() { "t", "u", "v" } },
                { '9', new List<string>() { "w", "x", "y", "z" } }
            };

            switch (digits.Length)
            {
                case 1:
                    return keyLetters[digits[0]];
                case 2:
                    foreach (string s1 in keyLetters[digits[0]])
                        foreach (string s2 in keyLetters[digits[1]])
                            result.Add(s1 + s2);
                    return result;
                case 3:
                    foreach (string s1 in keyLetters[digits[0]])
                        foreach (string s2 in keyLetters[digits[1]])
                            foreach (string s3 in keyLetters[digits[2]])
                                result.Add(s1 + s2 + s3);
                    return result;
                case 4:
                    foreach (string s1 in keyLetters[digits[0]])
                        foreach (string s2 in keyLetters[digits[1]])
                            foreach (string s3 in keyLetters[digits[2]])
                                foreach (string s4 in keyLetters[digits[3]])
                                    result.Add(s1 + s2 + s3 + s4);
                    return result;
                default: return result;
            }
        }
    }
}
