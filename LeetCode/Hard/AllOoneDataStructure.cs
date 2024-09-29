namespace LeetCode.Hard
{
    internal class AllOoneDataStructure
    {
        public class AllOne_Bad // O(n) solution for gets
        {

            readonly Dictionary<string, int> str = [];

            public void Inc(string key)
            {
                if (str.TryGetValue(key, out int value))
                    str[key] = ++value;
                else
                    str.Add(key, 1);
            }

            public void Dec(string key)
            {
                if (str[key] > 1)
                    str[key] = --str[key];
                else
                    str.Remove(key);
            }

            public string GetMaxKey()
            {
                string? key = null;
                int temp = 0;
                if (str.Count >= 1)
                {
                    foreach (var item in str)
                    {
                        if (item.Value >= temp)
                        {
                            temp = item.Value;
                            key = item.Key;
                        }
                    }
                }
                else
                {
                    return string.Empty;
                }
                return key!;
            }

            public string GetMinKey()
            {
                string? key = null;
                int temp = 0;
                if (str.Count >= 1)
                {
                    temp = str[GetMaxKey()];
                    foreach (var item in str)
                    {
                        if (item.Value <= temp)
                        {
                            temp = item.Value;
                            key = item.Key;
                        }
                    }
                }
                else
                {
                    return string.Empty;
                }
                return key!;
            }
        }
    }
}
