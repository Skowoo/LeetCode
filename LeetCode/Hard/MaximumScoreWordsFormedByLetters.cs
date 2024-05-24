namespace LeetCode.Hard
{
    internal class MaximumScoreWordsFormedByLetters
    {
        // Simplified, yet still not perfect code
        public static int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            int finalResult = 0;
            Dictionary<char, int> lettersDictionary = [];
            foreach (char c in letters)
                if (lettersDictionary.TryGetValue(c, out int value))
                    lettersDictionary[c]++;
                else
                    lettersDictionary[c] = 1;

            string[] validWords = words.Where(x => CheckIfWordsAreValid([x])).ToArray();
            FindAndCheckSubsets(validWords);

            return finalResult;

            int CalculateWordsScore(IEnumerable<string> words)
            {
                int result = 0;
                foreach (var word in words)
                    foreach (char c in word)
                        result += score[c - 'a'];

                return result;
            }

            bool CheckIfWordsAreValid(IEnumerable<string> words)
            {
                var copy = new Dictionary<char, int>(lettersDictionary);

                foreach (var word in words)
                    foreach (char c in word)
                        if (copy.TryGetValue(c, out int count))
                            if (count > 1)
                                copy[c]--;
                            else
                                copy.Remove(c);
                        else
                            return false;

                return true;
            }

            void FindAndCheckSubsets(string[] input)
            {
                int n = input.Length;
                for (int i = 0; i < (1 << n); i++)
                {
                    List<string> subset = [];
                    for (int j = 0; j < n; j++)
                        if ((i & (1 << j)) != 0)
                            subset.Add(input[j]);

                    if (CheckIfWordsAreValid(subset))
                        finalResult = Math.Max(finalResult, CalculateWordsScore(subset));
                }
            }
        }


        public static int MaxScoreWords__Old(string[] words, char[] letters, int[] score)
        {
            int finalResult = 0;
            Dictionary<char, int> lettersDictionary = [];
            foreach (char c in letters)
                if (lettersDictionary.TryGetValue(c, out int value))
                    lettersDictionary[c]++;
                else
                    lettersDictionary[c] = 1;

            string[] validWords = words.Where(x => CheckIfWordsAreValid(lettersDictionary, [x])).ToArray();

            var allPermutations = GenerateAllSubsets(validWords);

            List<List<string>> validPermutations = [];
            foreach (var perm in allPermutations)
                if (CheckIfWordsAreValid(lettersDictionary, perm))
                    validPermutations.Add(perm);

            foreach (var perm in validPermutations)
                finalResult = Math.Max(finalResult, CalculateWordsScore(perm));

            return finalResult;

            int CalculateWordsScore(IEnumerable<string> words)
            {
                int result = 0;
                foreach (var word in words)
                    foreach (char c in word)
                        result += score[c - 'a'];

                return result;
            }

            static bool CheckIfWordsAreValid(Dictionary<char, int> dictionary, IEnumerable<string> words)
            {
                var copy = new Dictionary<char, int>(dictionary);

                foreach (var word in words)
                    foreach (char c in word)
                        if (copy.TryGetValue(c, out int count))
                            if (count > 1)
                                copy[c]--;
                            else
                                copy.Remove(c);
                        else
                            return false;

                return true;
            }

            static List<List<string>> GenerateAllSubsets(IEnumerable<string> A)
            {
                List<string> subset = [];
                List<List<string>> result = [];
                int index = 0;
                CalcSubset(A.ToList(), result, subset, index);
                return result;

                static void CalcSubset(List<string> A, List<List<string>> res, List<string> subset, int index)
                {
                    res.Add(new List<string>(subset));
                    for (int i = index; i < A.Count; i++)
                    {
                        subset.Add(A[i]);
                        CalcSubset(A, res, subset, i + 1);
                        subset.RemoveAt(subset.Count - 1);
                    }
                }
            }
        }
    }
}

// Console.WriteLine(MaxScoreWords(["dog", "cat", "dad", "good"], ['a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o'], [1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]));
