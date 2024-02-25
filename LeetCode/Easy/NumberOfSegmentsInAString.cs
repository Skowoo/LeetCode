namespace LeetCode.Easy
{
    internal class NumberOfSegmentsInAString
    {
        public int CountSegments(string s) => s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
