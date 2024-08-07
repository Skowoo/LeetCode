namespace LeetCode.Medium
{
    internal class CountNumberOfTeams
    {
        public static int NumTeams(int[] rating)
        {
            int result = 0;
            int[] decreasing = new int[rating.Length];
            int[] incresing = new int[rating.Length];

            for (int i = 0; i < rating.Length; i++)
                for (int j = i + 1; j < rating.Length; j++)
                    if (rating[i] > rating[j])
                        decreasing[i]++;
                    else
                        incresing[i]++;

            for (int i = 0; i < rating.Length; i++)
                for (int j = i + 1; j < rating.Length; j++)
                    if (rating[i] > rating[j])
                        result += decreasing[j];
                    else
                        result += incresing[j];

            return result;
        }
    }
}
