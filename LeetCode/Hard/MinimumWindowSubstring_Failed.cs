//namespace LeetCode
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine(MinWindow("ADOBECODEBANC", "ABC"));
//            Console.WriteLine(MinWindow("a", "a"));
//            Console.WriteLine(MinWindow("a", "aa"));
//        }

//        public static string MinWindow(string s, string t)
//        {
//            if (s.Length <= t.Length)
//                if (s == t)
//                    return s;
//                else
//                    return string.Empty;

//            Dictionary<char, List<int>> sourceDictionary = new();

//            for (int i = 0; i < s.Length; i++)
//                if (sourceDictionary.ContainsKey(s[i]))
//                    sourceDictionary[s[i]].Add(i);
//                else if (t.Contains(s[i]))
//                    sourceDictionary[s[i]] = new List<int> { i };

//            List<int> answerIndexes = new();

//            return s[answerIndexes.Min()..answerIndexes.Max()];
//        }
//    }
//}
