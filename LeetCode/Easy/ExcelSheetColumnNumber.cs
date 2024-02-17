namespace LeetCode.Easy
{
    internal class ExcelSheetColumnNumber
    {

        public static int TitleToNumber(string columnTitle) // -64
        {
            int result = 0;
            for (int i = 0; i < columnTitle.Length; i++)
                result = result * 26 + columnTitle[i] - 64;

            return result;
        }
    }
}

//Console.WriteLine(TitleToNumber("ZY"));
//Console.WriteLine(TitleToNumber("AB"));
//Console.WriteLine(TitleToNumber("A"));