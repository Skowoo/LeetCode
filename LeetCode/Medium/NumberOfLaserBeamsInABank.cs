namespace LeetCode.Medium
{
    internal class NumberOfLaserBeamsInABank
    {
        public static int NumberOfBeams(string[] bank)
        {
            int beamsCounter = 0, previousNodes = 0;

            for (int i = 0; i < bank.Length; i++)
            {
                int nodes = bank[i].ToCharArray().Where(x => x == '1').Count();
                if (nodes != 0)
                {
                    beamsCounter += nodes * previousNodes;
                    previousNodes = nodes;
                }
            }

            return beamsCounter;
        }
    }
}
