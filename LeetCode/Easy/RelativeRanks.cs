namespace LeetCode.Easy
{
    internal class RelativeRanks
    {
        public static string[] FindRelativeRanks(int[] score)
        {
            Dictionary<int, string> scoresDictionary = new();
            foreach (int i in score)
                scoresDictionary.Add(i, "");

            int counter = 1;
            foreach (var i in scoresDictionary.OrderByDescending(x => x.Key))
            {
                scoresDictionary[i.Key] = counter switch
                {
                    1 => "Gold Medal",
                    2 => "Silver Medal",
                    3 => "Bronze Medal",
                    _ => counter.ToString(),
                };
                counter++;
            }

            return scoresDictionary.Values.ToArray();
        }
    }
}
