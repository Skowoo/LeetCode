namespace LeetCode.Medium
{
    internal class KthSmallestPrimeFraction
    {
        public static int[] KthSmallestPrimeFraction__SlowFunc(int[] arr, int k)
        {
            Dictionary<int[], double> allFractions = new();
            for (int i = 0; i < arr.Length; i++)
                for (int j = i; j < arr.Length; j++)
                    allFractions.Add(new int[] { arr[i], arr[j] }, (double)arr[i] / arr[j]);

            var resultArray = allFractions.OrderBy(a => a.Value).Select(a => a.Key).ToArray();

            return resultArray[k - 1];
        }
    }
}

// var result = KthSmallestPrimeFraction(new int[] { 1, 2, 3, 5 }, 3);
// foreach (int i in result)
//     Console.WriteLine(i);