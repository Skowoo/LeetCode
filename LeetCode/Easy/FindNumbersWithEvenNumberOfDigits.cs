namespace LeetCode.Easy
{
    internal class FindNumbersWithEvenNumberOfDigits
    {
        public static int FindNumbers(int[] nums)
        {
            int counter = 0;

            foreach (int x in nums)
                if (x.ToString().Length % 2 == 0)
                    counter++;

            return counter;
        }
    }
}
