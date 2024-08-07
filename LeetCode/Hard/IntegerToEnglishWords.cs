namespace LeetCode.Hard
{
    internal class IntegerToEnglishWords
    {
        public static string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";
            if (num < 10)
                return new[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }[num - 1];
            if (num < 20)
                return new[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" }[num - 10];
            if (num < 100)
                return new[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }[num / 10 - 2] + (num % 10 == 0 ? "" : " " + NumberToWords(num % 10));
            if (num < 1000)
                return NumberToWords(num / 100) + " Hundred" + (num % 100 == 0 ? "" : " " + NumberToWords(num % 100));
            if (num < 1000000)
                return NumberToWords(num / 1000) + " Thousand" + (num % 1000 == 0 ? "" : " " + NumberToWords(num % 1000));
            if (num < 1000000000)
                return NumberToWords(num / 1000000) + " Million" + (num % 1000000 == 0 ? "" : " " + NumberToWords(num % 1000000));
            else
                return NumberToWords(num / 1000000000) + " Billion" + (num % 1000000000 == 0 ? "" : " " + NumberToWords(num % 1000000000));
        }
    }
}
