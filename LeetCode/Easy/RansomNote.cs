namespace LeetCode.Easy
{
    internal class RansomNote
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> baseLetters = new();

            foreach (char c in magazine)
                if (baseLetters.ContainsKey(c))
                    baseLetters[c]++;
                else
                    baseLetters.Add(c, 1);

            foreach (char c in ransomNote)
                if (baseLetters.ContainsKey(c))
                {
                    baseLetters[c]--;
                    if (baseLetters[c] < 1)
                        baseLetters.Remove(c);
                }
                else
                    return false;

            return true;
        }
    }
}
