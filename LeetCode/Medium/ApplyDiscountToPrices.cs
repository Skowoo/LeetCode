namespace LeetCode.Medium
{
    internal class ApplyDiscountToPrices
    {

        public static string DiscountPrices(string sentence, int discount)
        {
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
                if (words[i].StartsWith('$') && words[i].Length <= 11 && long.TryParse(words[i].Remove(0, 1), out long parsedValue))
                {
                    var result = parsedValue * (1 - discount / 100D);
                    words[i] = "$" + result.ToString("F2");
                }

            return string.Join(' ', words);
        }
    }
}

// Console.WriteLine(DiscountPrices("there are $1 $2 and 5$ an$100 an$100  $111 $1123gf  candies in the shop", 50));

// Not-used REGEX for valid price: @"\B\$\d{1,10}\b"