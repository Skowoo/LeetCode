namespace LeetCode.Easy
{
    internal class CountTheNumberOfConsistentStrings
    {
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            var allowedArray = allowed.ToCharArray();
            int result = 0;
            foreach (string word in words)
            {
                bool valid = true;
                foreach (char c in word)
                    if (!allowedArray.Contains(c))
                    {
                        valid = false;
                        break;
                    }
                if (valid)
                    result++;
            }
            return result;
        }
    }
}
