namespace LeetCode.Easy
{
    internal static class MergeTwo2DArraysBySummingValues
    {
        public static int[][] MergeArrays(int[][] nums1, int[][] nums2)
        {
            Dictionary<int, int> resultDictionary = [];

            foreach (var tuple in nums1)
                resultDictionary.Add(tuple[0], tuple[1]);

            foreach (var tuple in nums2)
                if (resultDictionary.TryGetValue(tuple[0], out int value))
                    resultDictionary[tuple[0]] = value + tuple[1];
                else
                    resultDictionary.Add(tuple[0], tuple[1]);

            List<int[]> resultList = [];
            foreach (var pair in resultDictionary.OrderBy(x => x.Key))
                resultList.Add([pair.Key, pair.Value]);

            return [.. resultList];
        }
    }
}
