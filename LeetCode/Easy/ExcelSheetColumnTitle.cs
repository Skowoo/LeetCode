using System.Text;

namespace LeetCode.Easy
{
    internal static class ExcelSheetColumnTitle
    {
        public static string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new();

            while (columnNumber > 0)
            {
                char letter = (char)(((columnNumber - 1) % 26) + 65);
                sb.Insert(0, letter);
                columnNumber = (columnNumber - 1) / 26;
            }

            return sb.ToString();
        }
    }
}
