namespace LeetCode.Medium
{
    internal class StringToInt_ATOI
    {
        public static int MyAtoi(string s)
        {
            s = s.Trim();

            if (s.Length < 1)
                return 0;

            bool isNegative = s.StartsWith('-');
            bool isSigned = s.StartsWith('+');

            for (int i = isNegative || isSigned ? 1 : 0; i < s.Length; i++)
                if (!char.IsDigit(s[i]))
                    s = s.Remove(i);

            Console.WriteLine(s);

            if (s.Length < 1)
                return 0;

            bool parsedSuccess = int.TryParse(s, out int result);

            if (parsedSuccess)
                return result;
            else if (s.Length < 8)
                return 0;
            else if (isNegative)
                return int.MinValue;
            else
                return int.MaxValue;
        }
    }
}
