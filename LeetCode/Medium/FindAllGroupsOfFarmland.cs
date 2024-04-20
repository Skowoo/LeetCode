namespace LeetCode.Medium
{
    internal class FindAllGroupsOfFarmland
    {
        public static int[][] FindFarmland(int[][] land)
        {
            List<int[]> results = new();
            bool[,] marked = new bool[land.Length, land[0].Length];

            for (int i = 0; i < land.Length; i++)
                for (int j = 0; j < land[0].Length; j++)
                    if (land[i][j] == 1 && !marked[i, j])
                    {
                        int[] currentField = new int[4] { i, j, -1, -1 };

                        int newI = i,
                            newJ = j;

                        while (newI < land.Length && land[newI][j] == 1)
                            newI++;

                        while (newJ < land[0].Length && land[i][newJ] == 1)
                            newJ++;

                        newI--;
                        newJ--;

                        if (!marked[newI, newJ])
                        {
                            currentField[2] = newI;
                            currentField[3] = newJ;
                            marked[newI, newJ] = true;
                            marked[i, j] = true;
                            results.Add(currentField);
                        }
                    }

            return results.ToArray();
        }
    }
}

//             _ = FindFarmland(new int[][] {
//                new int[] { 1,0,0 },
//                new int[] { 0,1,1},
//                new int[] { 0,1,1}
//            });