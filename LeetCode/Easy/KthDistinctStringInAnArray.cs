namespace LeetCode.Easy
{
    internal class KthDistinctStringInAnArray
    {
        public static string KthDistinct(string[] arr, int k)
        {
            Dictionary<string, int> dict = [];
            foreach (var item in arr)
                if (dict.TryGetValue(item, out int value))
                    dict[item] = ++value;
                else
                    dict.Add(item, 1);

            var distinct = dict.Where(x => x.Value == 1).Select(x => x.Key).ToList();
            return k > distinct.Count ? "" : distinct[k - 1];
        }
    }
}
