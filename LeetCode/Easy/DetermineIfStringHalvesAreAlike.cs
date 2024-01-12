namespace LeetCode.Easy
{
    internal class DetermineIfStringHalvesAreAlike
    {
        public static bool HalvesAreAlike(string s)
        {
            int Counter = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < s.Length; i++)
                if (vowels.Contains(s[i]))
                    if (i < s.Length / 2)
                        Counter++;
                    else
                        Counter--;

            return Counter == 0;
        }
    }
}
