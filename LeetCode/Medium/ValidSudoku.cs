namespace LeetCode.Medium
{
    internal class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            List<List<List<char>>> segments = new()
            {
                new() {
                    new List<char>(),
                    new List<char>(),
                    new List<char>()
                },
                new() {
                    new List<char>(),
                    new List<char>(),
                    new List<char>()
                },
                new() {
                    new List<char>(),
                    new List<char>(),
                    new List<char>()
                },
            };

            for (int i = 0; i < board.Length; i++)
            {
                List<char> rowList = new();
                List<char> colList = new();

                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.')
                        if (!rowList.Contains(board[i][j]))
                            rowList.Add(board[i][j]);
                        else
                            return false;

                    if (board[j][i] != '.')
                    {
                        if (!colList.Contains(board[j][i]))
                            colList.Add(board[j][i]);
                        else
                            return false;

                        if (!segments[j / 3][i / 3].Contains(board[j][i]))
                            segments[j / 3][i / 3].Add(board[j][i]);
                        else
                            return false;
                    }
                }

            }

            return true;
        }
    }
}
