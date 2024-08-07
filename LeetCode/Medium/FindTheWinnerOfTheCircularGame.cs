namespace LeetCode.Medium
{
    internal class FindTheWinnerOfTheCircularGame
    {
        public static int FindTheWinner(int n, int k)
        {
            Queue<int> line = new();

            for (int i = 1; i <= n; i++)
                line.Enqueue(i);

            while (line.Count > 1)
            {
                for (int i = 0; i < k - 1; i++)
                    line.Enqueue(line.Dequeue());

                line.Dequeue();
            }

            return line.Peek();
        }
    }
}
