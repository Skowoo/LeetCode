namespace LeetCode.Hard
{
    internal class MaximalRectangle
    {
        public static int MaximalRectangle_Func(char[][] matrix)
        {
            int result = 0;
            int[] heightMap = new int[matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                    heightMap[j] = matrix[i][j] == '1' ? heightMap[j] + 1 : 0;

                Stack<int> stack = new();
                int currentMaxPossibility = 0;
                int indexer = 0;

                while (indexer < heightMap.Length)
                    if (stack.Count == 0 || heightMap[stack.Peek()] <= heightMap[indexer])
                        stack.Push(indexer++);
                    else
                        currentMaxPossibility = Math.Max(currentMaxPossibility,
                            heightMap[stack.Pop()] * (stack.Count == 0 ? indexer : indexer - stack.Peek() - 1));


                while (stack.Any())
                    currentMaxPossibility = Math.Max(currentMaxPossibility,
                        heightMap[stack.Pop()] * (stack.Count == 0 ? indexer : indexer - stack.Peek() - 1));

                result = Math.Max(result, currentMaxPossibility);
            }

            return result;
        }
    }
}
