namespace LeetCode.Easy
{
    internal static class FinalArrayStateAfterKMultiplicationOperationsI
    {
        public static int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            var pq = new PriorityQueue<int, (int, int)>(Comparer<(int, int)>
                .Create((a, b) =>
                {
                    if (a.Item1 == b.Item1)
                        return a.Item2.CompareTo(b.Item2);

                    return a.Item1.CompareTo(b.Item1);
                }));

            for (int i = 0; i < nums.Length; i++)
                pq.Enqueue(i, (nums[i], i));

            while (k-- > 0)
            {
                int minValueIndex = pq.Dequeue();
                nums[minValueIndex] *= multiplier;
                pq.Enqueue(minValueIndex, (nums[minValueIndex], minValueIndex));
            }

            return nums;
        }
    }
}
