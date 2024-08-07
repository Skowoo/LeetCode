namespace LeetCode.Medium
{
    internal class AverageWaitingTime
    {
        public static double AverageWaitingTime_Func(int[][] customers)
        {
            double totalWaitingTime = 0D;
            int currentCookTime = 0;

            foreach (var customer in customers)
            {
                currentCookTime = Math.Max(currentCookTime, customer[0]);
                currentCookTime += customer[1];

                totalWaitingTime += currentCookTime - customer[0];
            }

            return totalWaitingTime / customers.Length;
        }
    }
}

// Console.WriteLine(AverageWaitingTime([[1, 2], [2, 5], [4, 3]]));