namespace LeetCode.Easy
{
    internal class NthTribonacciNumber
    {
        public static int Tribonacci(int n)
        {
            int[] array = new int[3 + n];
            array[0] = 0;
            array[1] = 1;
            array[2] = 1;

            if (n <= 2)
                return array[n];

            for (int i = 3; i <= n; i++)
                array[i] = array[i - 3] + array[i - 2] + array[i - 1];

            return array[n];
        }
    }
}
