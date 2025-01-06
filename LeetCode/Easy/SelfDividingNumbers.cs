namespace LeetCode.Easy
{
    internal static class SelfDividingNumbers
    {
        public static IList<int> SelfDividingNumbers_Func(int left, int right)
        {
            List<int> result = [];

            for (int i = left; i <= right; i++)
            {
                bool isValid = true;
                var digits = i.ToString()
                    .Select(x => int.Parse(x.ToString()))
                    .ToArray();

                foreach (var digit in digits)
                    if (digit == 0 || i % digit != 0)
                    {
                        isValid = false;
                        break;
                    }

                if (isValid)
                    result.Add(i);
            }

            return result;
        }
    }
}
