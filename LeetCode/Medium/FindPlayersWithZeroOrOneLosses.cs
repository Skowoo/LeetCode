namespace LeetCode.Medium
{
    internal class FindPlayersWithZeroOrOneLosses
    {
        public static IList<IList<int>> FindWinners(int[][] matches)
        {
            Dictionary<int, int> lostGames = new();
            List<int> allPlayers = new();

            foreach (int[] match in matches)
            {
                if (!lostGames.ContainsKey(match[1]))
                    lostGames.Add(match[1], 1);
                else
                    lostGames[match[1]]++;

                if (!allPlayers.Contains(match[0]))
                    allPlayers.Add(match[0]);

                if (!allPlayers.Contains(match[1]))
                    allPlayers.Add(match[1]);
            }

            int[] singleLoosers = lostGames.Keys.Where(x => lostGames[x] == 1).ToArray();
            int[] noLoosers = allPlayers.Where(x => !lostGames.ContainsKey(x)).ToArray();

            Array.Sort(noLoosers);
            Array.Sort(singleLoosers);

            return new int[][] { noLoosers, singleLoosers };
        }
    }
}
