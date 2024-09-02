namespace LeetCode.Medium
{
    internal class FindTheStudentThatWillReplaceTheChalk
    {
        public static int ChalkReplacer(int[] chalk, int k)
        {
            long sum = 0;
            foreach (var c in chalk)
                sum += c;

            long leftover = k % sum;
            int indexer = 0;

            while (leftover >= 0)
                leftover -= chalk[indexer++];

            return indexer - 1;
        }
    }
}
