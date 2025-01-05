using System.Text;

namespace LeetCode.Medium
{
    internal static class ShiftingLettersII
    {
        public static string ShiftingLetters(string s, int[][] shifts)
        {
            int[] totalShiftValues = new int[s.Length];
            foreach (var shift in shifts)
                for (int i = shift[0]; i <= shift[1]; i++)
                    if (shift[2] == 1)
                        totalShiftValues[i]++;
                    else
                        totalShiftValues[i]--;

            StringBuilder result = new();

            for (int i = 0; i < totalShiftValues.Length; i++)
            {
                int originalLetterNumber = s[i] - 96;
                int newLetterNumber = (originalLetterNumber + totalShiftValues[i]) % 26;
                int offset = newLetterNumber > 0 ? newLetterNumber : 26 + newLetterNumber;
                result.Append((char)(offset + 96));
            }

            return result.ToString();
        }
    }
}
