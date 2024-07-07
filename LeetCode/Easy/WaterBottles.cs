namespace LeetCode.Easy
{
    internal class WaterBottles
    {
        public static int NumWaterBottles(int numBottles, int numExchange)
        {
            int emptyBottles = 0,
                result = 0;

            do
            {
                result += numBottles;
                emptyBottles += numBottles;
                numBottles = emptyBottles / numExchange;
                emptyBottles = emptyBottles % numExchange;
            }
            while (numBottles > 0);

            return result;
        }
    }
}
