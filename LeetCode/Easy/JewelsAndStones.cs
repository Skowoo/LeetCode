namespace LeetCode.Easy
{
    internal static class JewelsAndStones
    {
        public static int NumJewelsInStones(string jewels, string stones)
            => stones.ToCharArray().Count(x => jewels.ToCharArray().Contains(x));
    }
}
