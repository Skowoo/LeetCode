namespace LeetCode.Medium
{
    internal class FindThePrefixCommonArrayOfTwoArrays
    {
        public static int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            int[] result = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                result[i] = A.Take(i + 1).Intersect(B.Take(i + 1)).Count();

            return result;
        }
    }
}
