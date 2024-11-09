namespace LeetCode.Easy
{
    internal class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            var arrayA = s.ToCharArray();
            var arrayB = t.ToCharArray();
            Array.Sort(arrayA);
            Array.Sort(arrayB);
            return new String(arrayA).Equals(new String(arrayB));
        }
    }
}
