namespace LeetCode.Easy
{
    internal class RelativeSortArray
    {
        public static int[] RelativeSortArray_Fnc(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> ordered = [];
            List<int> leftover = [];

            foreach (int num in arr1)
                if (arr2.Contains(num))
                    if (ordered.ContainsKey(num))
                        ordered[num]++;
                    else
                        ordered[num] = 1;
                else
                    leftover.Add(num);

            List<int> result = [];

            foreach (int num in arr2)
                for (int i = 0; i < ordered[num]; i++)
                    result.Add(num);

            result.AddRange(leftover.OrderBy(x => x));

            return [.. result];
        }
    }
}
