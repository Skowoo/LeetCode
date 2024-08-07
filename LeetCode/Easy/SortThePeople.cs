namespace LeetCode.Easy
{
    internal class SortThePeople
    {
        public static string[] SortPeople(string[] names, int[] heights)
        {
            return names
                .Select((name, index) => new { Name = name, Height = heights[index] })
                .OrderByDescending(person => person.Height)
                .Select(person => person.Name)
                .ToArray();
        }
    }
}
