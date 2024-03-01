namespace LeetCode.Medium
{
    internal class PartitioningIntoMinimumNumberOfDeci_BinaryNumbers
    {
        public static int MinPartitions(string n)
        {
            char max = '0';
            foreach (char i in n)
            {
                if (i > max)
                    max = i;
                if (max == '9')
                    return 9;
            }

            return int.Parse(max.ToString());
        }

        //Faster
        public static int MinPartitionsLambda(string n) => n.Max(x => (int)x) - 64;
    }
}
