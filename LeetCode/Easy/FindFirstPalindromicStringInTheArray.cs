namespace LeetCode.Easy
{
    internal class FindFirstPalindromicStringInTheArray
    {
        public static string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                bool isPali = true;

                for (int i = 0; i <= word.Length / 2; i++)
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPali = false;
                        break;
                    }

                if (isPali)
                    return word;
            }

            return string.Empty;
        }
    }
}

//Console.WriteLine(FirstPalindrome(new string[] { "abc", "car", "ada", "racecar", "cool" }));