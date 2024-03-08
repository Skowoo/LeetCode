namespace LeetCode.Easy
{
    internal class CountElementsWithMaximumFrequency
    {
        public static int MaxFrequencyElements(int[] nums)
        {
            Dictionary<int, int> numbersCounter = new();

            foreach (int num in nums)
                if (numbersCounter.ContainsKey(num))
                    numbersCounter[num]++;
                else
                    numbersCounter.Add(num, 1);

            return numbersCounter.Where(x => x.Value == numbersCounter.Values.Max()).Select(x => x.Value).Sum();
        }
    }
}
