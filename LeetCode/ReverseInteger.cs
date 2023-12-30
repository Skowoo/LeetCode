namespace LeetCode
{
    internal class ReverseInteger
    {
        public static int Reverse(int x)
        {
            bool negative = x < 0;
            string inputNumber = x.ToString().Trim('-');
            string outputNumber = negative ? "-" : "";
            for (int i = 1; i <= inputNumber.Length; i++)
                outputNumber += inputNumber[^i];

            bool parsed = int.TryParse(outputNumber, out int parseResult);
            return parsed ? parseResult : 0;
        }
    }
}
