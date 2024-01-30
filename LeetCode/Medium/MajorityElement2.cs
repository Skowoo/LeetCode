namespace LeetCode.Medium
{
    internal class MajorityElement2
    {
        public static IList<int> MajorityElement(int[] nums)
        {
            Dictionary<int, int> dictionary = new();

            foreach (int num in nums)
                if (dictionary.ContainsKey(num))
                    dictionary[num]++;
                else
                    dictionary.Add(num, 1);

            return dictionary.Where(x => x.Value > nums.Length / 3).Select(x => x.Key).ToArray();
        }
    }
}
