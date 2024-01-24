namespace LeetCode.Easy
{
    internal class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            int[][] result = new int[numRows][];

            for (int i = 1; i <= numRows; i++)
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

            return result.ToArray();
        }
    }
}

//var array1 = Generate(5);

//foreach (var x in array1)
//{
//    foreach (var y in x)
//        Console.Write(y);
//    Console.WriteLine();
//}

//Console.WriteLine(array1.Count);
