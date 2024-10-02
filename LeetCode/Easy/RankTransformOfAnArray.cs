namespace LeetCode.Easy
{
    internal class RankTransformOfAnArray
    {
        public static int[] ArrayRankTransform(int[] arr)
        {
            Dictionary<int, int> dic = [];
            foreach (int i in arr)
                dic.TryAdd(i, i);

            int rank = 1;
            foreach (var i in dic.OrderBy(x => x.Key))
                dic[i.Key] = rank++;

            for (int i = 0; i < arr.Length; i++)
                arr[i] = dic[arr[i]];

            return arr;
        }
    }
}
