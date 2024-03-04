namespace LeetCode.Medium
{
    internal class BagOfTokens
    {
        public static int BagOfTokensScore(int[] tokens, int power)
        {
            Array.Sort(tokens);

            int smallest = 0, biggest = tokens.Length - 1, result = 0;

            while (smallest <= biggest)
            {
                if (power >= tokens[smallest])
                {
                    power -= tokens[smallest++];
                    result++;
                }
                else
                {
                    if (result == 0 || smallest == biggest)
                        break;
                    power += tokens[biggest--];
                    result--;
                }
            }

            return result;
        }
    }
}

// Console.WriteLine(BagOfTokensScore(new int[] { 200, 100}, 150));