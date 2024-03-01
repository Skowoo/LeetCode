//using System;

//namespace LeetCode
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            //char[][] array = new char[][]
//            //{
//            //    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
//            //    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
//            //    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
//            //    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
//            //    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
//            //    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
//            //    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
//            //    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
//            //    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
//            //};

//            //foreach (char[] c in array)
//            //{
//            //    foreach (char x in c)
//            //        Console.Write(x + " ");
//            //    Console.Write(Environment.NewLine);
//            //}

//            //SolveSudoku(array);

//            //Console.WriteLine("Solved:");

//            //foreach (char[] c in array)
//            //{
//            //    foreach (char x in c)
//            //        Console.Write(x + " ");
//            //    Console.Write(Environment.NewLine);
//            //}

//            //Console.WriteLine();
//            Console.WriteLine();

//            char[][] array2 = new char[][]
//            {
//                new char[] {'.', '.', '9', '7', '4', '8', '.', '.', '.'},
//                new char[] {'7', '.', '.', '.', '.', '.', '.', '.', '.'},
//                new char[] {'.', '2', '.', '1', '.', '9', '.', '.', '.'},
//                new char[] {'.', '.', '7', '.', '.', '.', '2', '4', '.'},
//                new char[] {'.', '6', '4', '.', '1', '.', '5', '9', '.'},
//                new char[] {'.', '9', '8', '.', '.', '.', '3', '.', '.'},
//                new char[] {'.', '.', '.', '8', '.', '3', '.', '2', '.'},
//                new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '6'},
//                new char[] {'.', '.', '.', '2', '7', '5', '9', '.', '.'}
//            };

//            foreach (char[] c in array2)
//            {
//                foreach (char x in c)
//                    Console.Write(x + " ");
//                Console.Write(Environment.NewLine);
//            }

//            SolveSudoku(array2);

//            Console.WriteLine("Solved:");

//            foreach (char[] c in array2)
//            {
//                foreach (char x in c)
//                    Console.Write(x + " ");
//                Console.Write(Environment.NewLine);
//            }

//            Console.ReadKey();
//        }

//        public static void SolveSudoku(char[][] board)
//        {
//            List<char>[,] possibilities = new List<char>[9, 9];

//            for (int row = 0; row < board.Length; row++)
//                for (int col = 0; col < board[row].Length; col++)
//                    if (board[row][col] == '.')
//                    {
//                        List<char> possibleDigits = new() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

//                        for (int i = 0; i < board.Length; i++)
//                            if (board[row][i] != '.' && possibleDigits.Contains(board[row][i]))
//                                possibleDigits.Remove(board[row][i]);

//                        for (int i = 0; i < board.Length; i++)
//                            if (board[i][col] != '.' && possibleDigits.Contains(board[i][col]))
//                                possibleDigits.Remove(board[i][col]);

//                        int rowSectorStart = row / 3 * 3;
//                        int colSectorStart = col / 3 * 3;

//                        for (int i = rowSectorStart; i < rowSectorStart + 3; i++)
//                            for (int j = colSectorStart; j < colSectorStart + 3; j++)
//                                if (board[i][j] != '.' && possibleDigits.Contains(board[i][j]))
//                                    possibleDigits.Remove(board[i][j]);

//                        if (possibleDigits.Count == 1)
//                        {
//                            possibilities[row, col] = null;
//                            board[row][col] = possibleDigits.Single();
//                            row = 0;
//                            col = 0;
//                        }
//                        else
//                        {
//                            possibilities[row, col] = possibleDigits;
//                        }
//                    }


//            #region Write filled or possibilities count

//            Console.WriteLine("\nSizes after first region:\n");
//            for (int row = 0; row < board.Length; row++)
//            {
//                for (int col = 0; col < board[row].Length; col++)
//                    if (board[row][col] != '.')
//                    {
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.Write(board[row][col] + " ");
//                        Console.ResetColor();
//                    }
//                    else
//                    {
//                        Console.ForegroundColor = ConsoleColor.Red;
//                        Console.Write(possibilities[row, col].Count + " ");
//                        Console.ResetColor();
//                    }
//                Console.Write(Environment.NewLine);
//            }
//            Console.WriteLine("\nEnd of sizes\n");
//            Console.ResetColor();
//            #endregion
//        }
//    }
//}
