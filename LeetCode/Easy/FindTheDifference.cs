namespace LeetCode.Easy
{
    internal class FindTheDifference
    {
        public static char FindTheDifferenceFunc(string s, string t)
        {
            Dictionary<char, int> sDictionary = new();
            Dictionary<char, int> tDictionary = new();

            foreach (char c in s)
                if (sDictionary.ContainsKey(c))
                    sDictionary[c]++;
                else
                    sDictionary.Add(c, 1);

            foreach (char c in t)
                if (tDictionary.ContainsKey(c))
                    tDictionary[c]++;
                else
                    tDictionary.Add(c, 1);

            foreach (char c in sDictionary.Keys)
                tDictionary[c] -= sDictionary[c];

            return tDictionary.Where(x => x.Value == 1).Single().Key;
        }
    }
}
