namespace LeetCode.Easy
{
    internal class CheckIfTwoStringArraysAreEquivalent
    {
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2) => string.Join("", word1) == string.Join("", word2);
    }
}
