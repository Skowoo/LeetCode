namespace LeetCode.Easy
{
    internal class FirstUniqueCharacterInAString
    {
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> kvp = new();

            for (int i = 0; i < s.Length; i++)
                if (kvp.ContainsKey(s[i]))
                    kvp[s[i]] = -2;
                else
                    kvp.Add(s[i], i);

            var result = kvp.Where(x => x.Value != -2);

            return result.Any() ? result.First().Value : -1;
        }
    }
}
