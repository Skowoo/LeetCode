﻿namespace LeetCode.Easy
{
    internal static class FinalPricesWithASpecialDiscountInAShop
    {
        public static int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length - 1; i++)
                for (int j = i + 1; j < prices.Length; j++)
                    if (prices[j] <= prices[i])
                    {
                        prices[i] -= prices[j];
                        break;
                    }

            return prices;
        }
    }
}
