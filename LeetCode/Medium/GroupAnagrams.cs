namespace LeetCode.Medium
{
    internal class GroupAnagrams
    {
        public static IList<IList<string>> GroupAnagramsFunc(string[] strs)
        {
            List<List<string>> result = new();

            long? previousValue = null;
            int listIndex = 0;

            foreach (var word in strs.OrderBy(x => x.ToCharArray().Sum(x => (long)x * x * x * x * x)))
            {
                long currentValue = word.ToCharArray().Sum(x => (long)x * x * x * x * x);

                if (previousValue is null)
                {
                    previousValue = currentValue;
                    result.Add(new List<string>());
                    result[listIndex].Add(word);
                }
                else if (previousValue != currentValue)
                {
                    result.Add(new List<string>());
                    listIndex++;
                    result[listIndex].Add(word);
                    previousValue = currentValue;
                }
                else
                {
                    result[listIndex].Add(word);
                }
            }

            return result.ToArray();
        }
    }
}
