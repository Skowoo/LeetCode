namespace LeetCode.Easy
{
    internal class BuyTwoChocolates
    {
        public static int BuyChoco(int[] prices, int money)
        {
            var twoChocos = prices.OrderBy(x => x).Take(2).Sum();
            if (twoChocos <= money)
                return money - twoChocos;
            else return money;
        }
    }
}
