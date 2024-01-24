namespace LeetCode.Easy
{
    internal class PascalTriangle2
    {
        public static IList<int> GetRow(int rowIndex)
        {
            int[][] result = new int[rowIndex + 1][];

            for (int i = 1; i <= rowIndex + 1; i++)
            {
                int[] currentArray = new int[i];
                currentArray[0] = 1;

                for (int j = 1; j < i; j++)
                {
                    if (j == i - 1)
                    {
                        currentArray[j] = 1;
                        break;
                    }

                    currentArray[j] = result[i - 2][j - 1] + result[i - 2][j];
                }

                result[i - 1] = currentArray;
            }

            return result[rowIndex];
        }
    }
}

//var result = GetRow(3);

//foreach (var row in result)
//    Console.Write(row + " ");