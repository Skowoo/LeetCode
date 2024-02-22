namespace LeetCode.Easy
{
    internal class FindTheTownJudge
    {
        public static int FindJudge(int n, int[][] trust)
        {
            int[,] persons = new int[n + 1, 2];

            foreach (var i in trust)
            {
                persons[i[0], 0]++;
                persons[i[1], 1]++;
            }

            int candidatesCounter = 0, target = 0;

            for (int i = 1; i <= n; i++)
            {
                if (persons[i, 0] == 0 && persons[i, 1] == n - 1)
                {
                    candidatesCounter++;
                    target = i;

                    if (candidatesCounter > 1)
                        return -1;
                }
            }

            return candidatesCounter == 1 ? target : -1;
        }
    }
}


//int[][] test =
//{
//                new int[] { 1, 3, },
//                new int[] { 2, 3, },
//            };
//Console.WriteLine(FindJudge(3, test));