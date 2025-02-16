namespace LeetCode.Easy
{
    internal static class ReplaceElementsWithGreatestElementOnRightSide
    {
        public static int[] ReplaceElements(int[] arr)
        {
            int prevMax = -1;
            int currNum;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                currNum = arr[i];
                arr[i] = prevMax;
                prevMax = Math.Max(prevMax, currNum);
            }

            return arr;
        }
    }
}
