namespace LeetCode.Medium
{
    internal class LeastNumberOfUniqueIntegersAfterKRemovals
    {
        public static int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            Dictionary<int, int> numsCounter = new();

            foreach (var a in arr)
                numsCounter[a] = numsCounter.ContainsKey(a) ? numsCounter[a] + 1 : 1;


            numsCounter = numsCounter.OrderBy(s => s.Value).ToDictionary(s => s.Key, s => s.Value);

            foreach (var pair in numsCounter)
            {
                int key = pair.Key, value = pair.Value;
                if (k > 0)
                {
                    if (value <= k)
                    {
                        k -= value;
                        numsCounter[key] = 0;
                    }
                    else
                        break;

                    if (numsCounter[key] == 0)
                        numsCounter.Remove(key);
                }
                else break;
            }

            return numsCounter.Count;
        }
    }
}
