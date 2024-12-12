namespace LeetCode.Easy
{
    internal static class TakeGiftsFromTheRichestPile
    {
        public static long PickGifts(int[] gifts, int k)
        {
            long sum = 0;
            PriorityQueue<int, int> priorityQueue = new();

            foreach (int gift in gifts)
            {
                priorityQueue.Enqueue(gift, -gift);
                sum += gift;
            }

            while (k-- > 0)
            {
                var currrent = priorityQueue.Dequeue();
                int newValue = (int)Math.Floor(Math.Sqrt(currrent));
                sum -= (currrent - newValue);
                priorityQueue.Enqueue(newValue, -newValue);
            }

            return sum;
        }

        public static long PickGifts_Bad(int[] gifts, int k) // Uneffective solution
        {
            while (k-- > 0)
            {
                Array.Sort(gifts);
                gifts[^1] = (int)Math.Floor(Math.Sqrt(gifts[^1]));
            }

            long result = 0;
            foreach (int gift in gifts)
                result += gift;

            return result;
        }
    }
}

// Console.WriteLine(PickGifts([25, 64, 9, 4, 100], 4)); // 29