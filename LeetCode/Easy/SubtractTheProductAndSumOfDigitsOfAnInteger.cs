namespace LeetCode.Easy
{
    public static class SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public static int SubtractProductAndSum(int n)
        {
            int product = 1,
                sum = 0;

            foreach (var d in n.ToString())
            {
                int digit = int.Parse(d.ToString());
                product *= digit;
                sum += digit;
            }

            return product - sum;
        }
    }
}
