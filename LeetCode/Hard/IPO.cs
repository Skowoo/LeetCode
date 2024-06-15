namespace LeetCode.Hard
{
    internal class IPO
    {
        public static int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            Array.Sort(capital, profits);
            PriorityQueue<int, int> queue = new();
            int indexer = 0;
            while (k > 0)
            {
                while (indexer < capital.Length && w >= capital[indexer])
                {
                    queue.Enqueue(profits[indexer], -profits[indexer]);
                    indexer++;
                }
                if (queue.Count == 0)
                    return w;
                w += queue.Dequeue();
                k--;
            }
            return w;
        }
    }
}
