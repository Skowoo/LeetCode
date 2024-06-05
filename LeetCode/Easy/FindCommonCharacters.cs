namespace LeetCode.Easy
{
    public class FindCommonCharacters
    {
        public static IList<string> CommonChars(string[] words)
        {
            HashSet<char> commonChars = new(words[0]);
            for (int i = 1; i < words.Length; i++)
                commonChars.IntersectWith(words[i]);

            char[] commonCharsArray = [.. commonChars];

            Dictionary<char, int> dict = [];
            foreach (char c in words[0])
                if (commonChars.Contains(c))
                {
                    if (dict.ContainsKey(c))
                        dict[c]++;
                    else
                        dict.Add(c, 1);
                }

            for (int i = 0; i < words.Length; i++)
            {
                Dictionary<char, int> tempDict = [];
                foreach (char c in words[i])
                    if (commonChars.Contains(c))
                    {
                        if (tempDict.ContainsKey(c))
                            tempDict[c]++;
                        else
                            tempDict.Add(c, 1);
                    }

                for (int j = 0; j < commonChars.Count; j++)
                    dict[commonCharsArray[j]] = Math.Min(dict[commonCharsArray[j]], tempDict[commonCharsArray[j]]);
            }

            List<string> result = [];
            foreach (char c in commonCharsArray)
                for (int i = 0; i < dict[c]; i++)
                    result.Add(c.ToString());

            return result;
        }
    }
}
