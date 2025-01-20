namespace LeetCode.Easy
{
    internal static class LastStoneWeight
    {
        public static int LastStoneWeight_Func(int[] stones)
        {
            List<int> stonesList = [.. stones];
            while (stonesList.Count > 1)
            {
                stonesList = [.. stonesList.OrderByDescending(s => s)];
                int a = stonesList[0];
                int b = stonesList[1];
                if (a == b)
                {
                    stonesList.RemoveAt(1);
                    stonesList.RemoveAt(0);
                }
                else
                {
                    stonesList[1] = a - b;
                    stonesList.RemoveAt(0);
                }
            }

            return stonesList.Count > 0 ? stonesList[0] : 0;
        }
    }
}
