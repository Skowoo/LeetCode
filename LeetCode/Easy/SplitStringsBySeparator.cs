namespace LeetCode.Easy
{
    internal class SplitStringsBySeparator
    {
        public static IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            List<string> result = new();

            foreach (var item in words)
                result.AddRange(item.Split(separator, StringSplitOptions.RemoveEmptyEntries));

            return result;
        }
    }
}


// var result = SplitWordsBySeparator(new[] { "one.two.three", "four.five", "six" }, '.');

// foreach (var word in result)
//     Console.WriteLine(word);