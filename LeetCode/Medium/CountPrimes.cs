namespace LeetCode.Medium
{
    internal class CountPrimes
    {
        public static int CountPrimesFunc(int n)
        {
            if (n < 3)
                return 0;

            Dictionary<int, bool> numbers = [];

            for (int i = 0; i < n; i++)
                numbers.Add(i, i % 2 != 0);

            numbers[1] = false;
            numbers[2] = true;

            for (int i = 3; i < Math.Sqrt(n); i += 2)
                for (int j = i + i; j < n; j += i)
                    numbers[j] = false;

            int counter = 0;
            foreach (var value in numbers.Values)
                if (value)
                    counter++;

            return counter;
        }
    }
}
