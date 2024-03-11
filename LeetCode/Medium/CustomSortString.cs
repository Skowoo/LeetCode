namespace LeetCode.Medium
{
    internal class CustomSortString
    {
        public static string CustomSortString_LambdaSort(string order, string s)
        {
            var orderArray = new int[26];
            for (int i = 0; i < order.Length; i++)
                orderArray[order[i] - 'a'] = i;

            var inputArray = s.ToCharArray();
            Array.Sort(inputArray, (x, y) => orderArray[x - 'a'].CompareTo(orderArray[y - 'a']));
            return string.Concat(inputArray);
        }

        public static string CustomSortString_Naive(string order, string s)
        {
            char[] inputArray = s.ToCharArray();
            List<char> letters = new();
            List<int> indexes = new();

            for (int i = 0; i < s.Length; i++)
                if (order.Contains(s[i]))
                {
                    letters.Add(s[i]);
                    indexes.Add(i);
                }

            List<char> sortedLetters = new();

            foreach (char c in order)
            {
                int letterCount = letters.Count(x => x == c);
                for (int i = 0; i < letterCount; i++)
                    sortedLetters.Add(c);
            }

            foreach (int index in indexes)
            {
                char nextChar = sortedLetters.First();
                inputArray[index] = nextChar;
                sortedLetters.Remove(nextChar);
            }

            return new string(inputArray);
        }
    }
}

// Console.WriteLine(CustomSortString("cba", "defaabbccdef"));