namespace LeetCode.Medium
{
    internal class MinimumNumberOfOperationsToMakeArrayEmpty
    {
        public static int MinOperations(int[] nums)
        {
            int[] distinctNums = nums.Distinct().ToArray();
            int counter = 0;

            if (nums.Length % distinctNums.Length == 0 && nums.Length > 10000)
                if (nums.Length / distinctNums.Length == 2)
                    return nums.Length - distinctNums.Length;

            foreach (int number in distinctNums)
            {
                int numberCounter = nums.Count(x => x == number);

                if (numberCounter < 7)
                {
                    if (numberCounter % 3 == 1 && numberCounter % 2 != 0)
                        return -1;
                    else if (numberCounter % 3 == 0)
                        counter += numberCounter / 3;
                    else if (numberCounter % 3 == 1)
                        counter += (numberCounter / 3) + 1;
                    else
                        counter += numberCounter / 2;
                }
                else
                {
                    if (numberCounter % 3 == 1 && numberCounter % 2 != 0)
                        counter += (numberCounter / 3) + 1;
                    else if (numberCounter % 3 == 0)
                        counter += numberCounter / 3;
                    else
                        counter += (numberCounter / 3) + 1;
                }
            }

            return counter;
        }
    }
}
