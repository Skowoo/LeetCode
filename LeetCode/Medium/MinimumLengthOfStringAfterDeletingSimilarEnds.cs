namespace LeetCode.Medium
{
    internal class MinimumLengthOfStringAfterDeletingSimilarEnds
    {
        public static int MinimumLength(string s)
        {
            if (s.Length == 1)
                return s.Length;

            int result = s.Length;
            int frontPointer = 0, endPointer = s.Length - 1;

            while (result > 0 && frontPointer < endPointer)
            {
                char currentChar = s[frontPointer];

                if (currentChar == s[endPointer])
                    result -= 2;
                else break;

                if (s[frontPointer + 1] == currentChar)
                    while (s[frontPointer + 1] == currentChar && result > 0 && frontPointer <= endPointer)
                    {
                        frontPointer++;
                        result--;
                    }

                if (s[endPointer - 1] == currentChar)
                    while (s[endPointer - 1] == currentChar && result > 0 && frontPointer <= endPointer)
                    {
                        endPointer--;
                        result--;
                    }

                frontPointer++;
                endPointer--;
            }

            return result;
        }
    }
}


//Console.WriteLine(MinimumLength("ca") == 2);
//Console.WriteLine(MinimumLength("cabaabac") == 0);
//Console.WriteLine(MinimumLength("a") == 1);
//Console.WriteLine(MinimumLength("bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb") == 1);