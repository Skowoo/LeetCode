namespace LeetCode.Medium
{
    internal class RevealCardsInIncreasingOrder
    {
        public static int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);
            int[] result = new int[deck.Length];
            Queue<int> queue = new(Enumerable.Range(0, deck.Length));

            for (int i = 0; i < deck.Length; i++)
            {
                result[queue.Dequeue()] = deck[i];
                if (queue.Count > 0)
                    queue.Enqueue(queue.Dequeue());
            }
            return result;
        }
    }
}
