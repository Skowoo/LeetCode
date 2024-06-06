namespace LeetCode.Medium
{
    // Identical solution will work for LeetCode 1296. Divide Array in Sets of K Consecutive Numbers ( DivideArrayInSetsOfKConsecutiveNumbers )
    internal class HandOfStraights
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
                return false;

            Array.Sort(hand);

            Dictionary<int, int> cardsDictionary = [];
            foreach (int card in hand)
                if (cardsDictionary.TryGetValue(card, out int value))
                    cardsDictionary[card] = ++value;
                else
                    cardsDictionary.Add(card, 1);

            foreach (int card in hand)
            {
                if (cardsDictionary[card] == 0)
                    continue;

                for (int i = 0; i < groupSize; i++)
                {
                    int currentCard = card + i;

                    if (!cardsDictionary.TryGetValue(currentCard, out int count) || count == 0)
                        return false;

                    cardsDictionary[currentCard] = --count;
                }
            }
            return true;
        }
    }
}
