namespace LeetCode.Medium
{
    internal class WordSearch
    {
        public static bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[0].Length; j++)
                    if (board[i][j] == word[0])
                        if (Search(i, j, 0))
                            return true;

            bool Search(int i, int j, int index)
            {
                if (i < 0 || i == board.Length || j < 0 || j == board[0].Length || index == word.Length || board[i][j] != word[index])
                    return false;

                if (index == word.Length - 1 && word[index] == board[i][j])
                    return true;

                char original = board[i][j];
                board[i][j] = '?';

                bool result =
                    Search(i, j - 1, index + 1) ||
                    Search(i, j + 1, index + 1) ||
                    Search(i - 1, j, index + 1) ||
                    Search(i + 1, j, index + 1);

                board[i][j] = original;

                return result;
            }

            return false;
        }
    }
}

//var testObj = new char[][]
//{
//    new char[] { 'A', 'B', 'C', 'E'},
//    new char[] { 'S', 'F', 'C', 'S'},
//    new char[] { 'A', 'D', 'E', 'E'}
//};
//Console.WriteLine(Exist(testObj, "SEE"));
//Console.WriteLine(Exist(testObj, "ABCCED"));
//Console.WriteLine(Exist(testObj, "ABCD"));