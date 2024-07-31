namespace LeetCode.Medium
{
    internal class FillingBookcaseShelves
    {
        public static int MinHeightShelves(int[][] books, int shelfWidth)
        {
            int[] memoryArray = new int[books.Length + 1];
            for (int i = 1; i <= books.Length; i++)
            {
                memoryArray[i] = int.MaxValue;

                int currHeight = 0,
                    currWidth = 0;

                for (int j = i; j > 0; j--)
                {
                    currWidth += books[j - 1][0];

                    if (currWidth > shelfWidth)
                        break;

                    currHeight = Math.Max(currHeight, books[j - 1][1]);
                    memoryArray[i] = Math.Min(memoryArray[i], memoryArray[j - 1] + currHeight);
                }
            }

            return memoryArray[books.Length];
        }
    }
}