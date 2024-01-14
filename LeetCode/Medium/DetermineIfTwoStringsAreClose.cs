namespace LeetCode.Medium
{
    internal class DetermineIfTwoStringsAreClose
    {
        public static bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            int[] sourceArray = new int[26];
            int[] targetArray = new int[26];

            foreach (char c in word1)
                sourceArray[c - 97]++;

            foreach (char c in word2)
                targetArray[c - 97]++;

            for (int i = 0; i < 26; i++)
                if (sourceArray[i] == 0 && targetArray[i] != 0 ||
                    sourceArray[i] != 0 && targetArray[i] == 0)
                    return false;

            Array.Sort(sourceArray);
            Array.Sort(targetArray);

            for (int i = 0; i < sourceArray.Length; i++)
                if (sourceArray[i] != targetArray[i])
                    return false;

            return true;
        }
    }
}
