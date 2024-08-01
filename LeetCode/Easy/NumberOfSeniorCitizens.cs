namespace LeetCode.Easy
{
    internal class NumberOfSeniorCitizens
    {
        public static int CountSeniors(string[] details)
        {
            int result = 0;
            foreach (string s in details)
                if (s[11] == '6' && s[12] > '0' || s[11] > '6')
                    result++;

            return result;
        }
    }
}
