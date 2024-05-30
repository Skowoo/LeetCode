namespace LeetCode.Medium
{
    internal class CountTripletsThatCanFormTwoArraysOfEqualXOR
    {
        public static int CountTriplets(int[] arr)
        {
            int[] cummulativeResult = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                cummulativeResult[i + 1] = cummulativeResult[i] ^ arr[i];

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (cummulativeResult[i] == cummulativeResult[j + 1])
                        result += (j - i);

            return result;
        }
    }
}
