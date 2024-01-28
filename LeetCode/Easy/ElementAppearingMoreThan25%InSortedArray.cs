namespace LeetCode.Easy
{
    internal class ElementAppearingMoreThan25_InSortedArray
    {
        public static int FindSpecialInteger(int[] arr)
        {
            Dictionary<int, int> occurences = new();

            foreach (int i in arr)
                if (occurences.ContainsKey(i))
                {
                    occurences[i]++;
                    if (occurences[i] > arr.Length / 4 + 1)
                        return i;
                }
                else
                    occurences.Add(i, 1);

            return occurences.Where(x => x.Value == occurences.Values.Max()).Single().Key;
        }
    }
}
