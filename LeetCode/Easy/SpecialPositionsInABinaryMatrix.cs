namespace LeetCode.Easy
{
    internal class SpecialPositionsInABinaryMatrix
    {
        public static int NumSpecial(int[][] mat)
        {
            int counter = 0;

            for (int i = 0; i < mat.Length; i++)
                for (int j = 0; j < mat[i].Length; j++)
                    if (mat[i][j] == 1)
                    {
                        bool isSpecial = true;

                        for (int k = 0; k < mat[i].Length; k++)
                            if (k != j && mat[i][k] == 1)
                            {
                                isSpecial = false;
                                break;
                            }

                        if (isSpecial)
                            for (int k = 0; k < mat.Length; k++)
                                if (k != i && mat[k][j] == 1)
                                {
                                    isSpecial = false;
                                    break;
                                }

                        if (isSpecial)
                            counter++;
                    }

            return counter;
        }
    }
}
