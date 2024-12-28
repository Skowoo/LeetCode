namespace LeetCode.Easy
{
    internal static class FindLuckyIntegerInAnArray
    {
        public static int FindLucky(int[] arr)
        {
            Dictionary<int, int> map = [];
            foreach (int i in arr)
                if (map.TryGetValue(i, out int value))
                    map[i] = ++value;
                else
                    map.Add(i, 1);

            int result = -1;
            foreach (var entry in map)
                if (entry.Key == entry.Value && entry.Value > result)
                    result = entry.Value;

            return result;
        }
    }
}
