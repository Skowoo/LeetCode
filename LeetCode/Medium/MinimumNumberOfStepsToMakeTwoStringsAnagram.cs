namespace LeetCode.Medium
{
    internal class MinimumNumberOfStepsToMakeTwoStringsAnagram
    {
        public static int MinSteps(string s, string t)
        {
            int differenceCounter = 0;

            Dictionary<char, int> sLetters = new();

            for (int i = 0; i < s.Length; i++)
                if (sLetters.ContainsKey(s[i]))
                    sLetters[s[i]]++;
                else
                    sLetters.Add(s[i], 1);

            foreach (char c in t)
                if (sLetters.ContainsKey(c))
                {
                    sLetters[c]--;
                    if (sLetters[c] == 0)
                        sLetters.Remove(c);
                }
                else
                    differenceCounter++;

            return differenceCounter;
        }
    }
}
