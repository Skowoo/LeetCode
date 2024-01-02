namespace LeetCode.Medium
{
    internal class ConverArrayTo2DArrayWithConditions
    {
        public static IList<IList<int>> FindMatrix(int[] nums)
        {
            List<List<int>> resultArray = new()
            {
                new List<int> { },
            };

            foreach (int num in nums)
                for (int i = 0; i < resultArray.Count + 1; i++)
                {
                    if (i == resultArray.Count)
                        resultArray.Add(new List<int>(num));

                    if (!resultArray[i].Contains(num))
                    {
                        resultArray[i].Add(num);
                        break;
                    }
                }

            return resultArray.ToArray();
        }
    }
}
