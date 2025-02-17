namespace LeetCode.Easy
{
    internal static class ShortestDistanceToACharacter
    {
        public static int[] ShortestToChar(string s, char c)
        {
            var result = new int[s.Length];

            int distance = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                    distance = 0;

                result[i] = distance;

                distance++;
            }

            distance = s.Length;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == c)
                    distance = 0;

                result[i] = Math.Min(distance, result[i]);

                distance++;
            }

            return result;
        }
    }
}
