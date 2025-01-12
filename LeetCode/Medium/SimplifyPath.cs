namespace LeetCode.Medium
{
    internal static class SimplifyPath
    {
        public static string SimplifyPath_Func(string path)
        {
            var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            List<string> result = [];

            foreach (var part in parts)
            {
                if (part == ".." && result.Count > 0)
                    result.RemoveAt(result.Count - 1);
                else if (part == ".." || part == ".")
                    continue;
                else
                    result.Add(part);
            }

            return $"/{string.Join('/', result)}";
        }
    }
}
