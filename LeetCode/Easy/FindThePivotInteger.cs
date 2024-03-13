namespace LeetCode.Easy
{
    internal class FindThePivotInteger
    {
        public static int PivotInteger(int n)
        {
            if (n == 1)
                return 1;
            else if (n < 8)
                return -1;

            int front = 1, end = n, frontSum = 1, endSum = n;

            while (end > front)
            {
                if (frontSum < endSum)
                {
                    front++;
                    frontSum += front;
                }
                else
                {
                    end--;
                    endSum += end;
                }

                if (end == front && endSum == frontSum)
                    return front;
            }

            return -1;
        }
    }
}

// Console.WriteLine(PivotInteger(8));