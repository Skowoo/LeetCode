namespace LeetCode.Medium
{
    internal class SingleNumber3
    {
        public static int[] SingleNumber(int[] nums)
        {
            Dictionary<int, int> dict = [];
            foreach (var num in nums)
                if (dict.TryGetValue(num, out int value))
                    dict[num] = ++value;
                else
                    dict.Add(num, 1);

            return dict.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
        }
    }
}

// var result = SingleNumber([1, 2, 1, 3, 2, 5]);
// Console.WriteLine($"{result[0]}, {result[1]}");