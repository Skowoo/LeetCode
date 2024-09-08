namespace LeetCode.Medium
{
    internal class SumOfSubarrayMinimums
    {
        public static int SumSubarrayMins(int[] arr)
        {
            int[] smallerLeft = new int[arr.Length],
                smallerRight = new int[arr.Length];
            Stack<int> stk = new();

            for (int i = 0; i < arr.Length; i++)
            {
                while (stk.Count > 0 && arr[i] < arr[stk.Peek()])
                    stk.Pop();

                smallerLeft[i] = stk.Count == 0 ? i + 1 : i - stk.Peek();
                stk.Push(i);
            }

            stk.Clear();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                while (stk.Count > 0 && arr[i] <= arr[stk.Peek()])
                    stk.Pop();

                smallerRight[i] = stk.Count == 0 ? arr.Length - i : stk.Peek() - i;
                stk.Push(i);
            }

            int result = 0;
            for (int i = 0; i < arr.Length; i++)
                result = (int)((result + (long)arr[i] * smallerLeft[i] * smallerRight[i]) % 1000000007);

            return result;
        }
    }
}
